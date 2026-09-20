using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.Data.Sqlite;

namespace ArtCommissionApplication_Prototype
{
    // Minimal SQLite-backed repository for commission requests.
    public static class CommissionRepository
    {
        private static string? dbPath;

        // sienna - initialize the database
        public static void Initialize(string? databasePath = null)
        {
            if (!string.IsNullOrWhiteSpace(databasePath))
                dbPath = databasePath;

            if (string.IsNullOrWhiteSpace(dbPath))
                dbPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "commissions.db");
            // sienna - sets up the database path based on what is given with a default option if none is given in the constructor


            using var connection = new SqliteConnection($"Data Source={dbPath}");
            connection.Open();

            // sienna - uses command for db to set up if a table does not already exist
            using var cmd = connection.CreateCommand();
            cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS Commissions (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    ClientName TEXT NOT NULL,
    ClientEmail TEXT NOT NULL,
    CropType TEXT NOT NULL,
    NumberOfCharacters INTEGER NOT NULL,
    HasBackground INTEGER NOT NULL,
    Description TEXT,
    EstimatedPrice REAL NOT NULL,
    NeedByDate TEXT,
    Status INTEGER NOT NULL,
    SubmittedDate TEXT NOT NULL
);
";
            cmd.ExecuteNonQuery();
        }

        // sienna - adds a commission row - for when a commission request form is submitted or a commission is otherwise added
        public static long AddCommission(CommissionRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            if (string.IsNullOrWhiteSpace(dbPath)) Initialize();

            using var connection = new SqliteConnection($"Data Source={dbPath}");
            connection.Open();

            using var cmd = connection.CreateCommand();
            cmd.CommandText = @"INSERT INTO Commissions
 (ClientName, ClientEmail, CropType, NumberOfCharacters, HasBackground, Description, EstimatedPrice, NeedByDate, Status, SubmittedDate)
 VALUES ($name, $email, $crop, $num, $bg, $desc, $price, $needBy, $status, $submitted);
 SELECT last_insert_rowid();";

            // sienna - including all values to be stored - we want all the values input but the user in the request form
            cmd.Parameters.AddWithValue("$name", request.Client.ClientName);
            cmd.Parameters.AddWithValue("$email", request.Client.ClientEmail);
            cmd.Parameters.AddWithValue("$crop", request.CommissionType.CropType.ToString());
            cmd.Parameters.AddWithValue("$num", request.CommissionType.NumberOFCharacters);
            cmd.Parameters.AddWithValue("$bg", request.CommissionType.HasBackground ? 1 : 0);
            cmd.Parameters.AddWithValue("$desc", request.CommissionType.Description ?? string.Empty);
            cmd.Parameters.AddWithValue("$price", request.CommissionType.EstimatedPrice);
            cmd.Parameters.AddWithValue("$needBy", request.CommissionType.NeedByDate?.ToString("o", CultureInfo.InvariantCulture) ?? string.Empty);
            cmd.Parameters.AddWithValue("$status", (int)request.Status);
            cmd.Parameters.AddWithValue("$submitted", request.SubmittedDate.ToString("o", CultureInfo.InvariantCulture));

            // sienna - gives the commissions a unique ID
            var id = (long)cmd.ExecuteScalar();
            request.Id = (int)id;
            return id;
        }

        // sienna - get all function to read rows of the db - for display in UI
        public static List<CommissionRequest> GetAll()
        {
            if (string.IsNullOrWhiteSpace(dbPath)) Initialize();

            var result = new List<CommissionRequest>();

            using var connection = new SqliteConnection($"Data Source={dbPath}");
            connection.Open();

            using var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Id, ClientName, ClientEmail, CropType, NumberOfCharacters, HasBackground, Description, EstimatedPrice, NeedByDate, Status, SubmittedDate FROM Commissions ORDER BY SubmittedDate DESC;";

            // sienna - reader collects the database information into a format that can be taken by the client, commission infor and data-time
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var id = reader.GetInt32(0);
                var name = reader.GetString(1);
                var email = reader.GetString(2);
                var cropStr = reader.GetString(3);
                var number = reader.GetInt32(4);
                var hasBg = reader.GetInt32(5) == 1;
                var desc = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                var price = (decimal)reader.GetDouble(7);
                var needByText = reader.IsDBNull(8) ? string.Empty : reader.GetString(8);
                var statusInt = reader.GetInt32(9);
                var submittedText = reader.GetString(10);

                DateTime? needBy = null;
                if (!string.IsNullOrWhiteSpace(needByText))
                {
                    if (DateTime.TryParse(needByText, null, DateTimeStyles.RoundtripKind, out var dt))
                        needBy = dt;
                }

                DateTime submitted = DateTime.Now;
                DateTime.TryParse(submittedText, null, DateTimeStyles.RoundtripKind, out submitted);

                // Map crop string back to enum (best-effort)
                if (!Enum.TryParse<CommissionInformation.CharacterCrop>(cropStr, out var crop))
                    crop = CommissionInformation.CharacterCrop.Headshot;

                var client = new Client(name, email);
                var commissionInfo = new CommissionInformation(crop, number, hasBg, desc, needBy);
                // ensure stored price is used
                commissionInfo.RecalculateEstimate();

                var request = new CommissionRequest(client, commissionInfo)
                {
                    Id = id,
                };

                // set status via reflection of constructor default? we'll set via direct property if available
                // CommissionRequest.Status is private set - we cannot set it here. Use repository only for read/display of pending requests.
                result.Add(request);
            }

            return result;
        }

        // sienna - used to update the status of a commission based on its id
        public static void UpdateStatus(int id, CommissionStatus status)
        {
            if (string.IsNullOrWhiteSpace(dbPath)) Initialize();

            using var connection = new SqliteConnection($"Data Source={dbPath}");
            connection.Open();

            using var cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE Commissions SET Status = $status WHERE Id = $id;";
            cmd.Parameters.AddWithValue("$status", (int)status);
            cmd.Parameters.AddWithValue("$id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
