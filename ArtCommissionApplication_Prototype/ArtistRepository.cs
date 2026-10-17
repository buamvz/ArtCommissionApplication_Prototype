using Microsoft.Data.Sqlite;
using System;

namespace ArtCommissionApplication_Prototype
{
    public static class ArtistRepository
    {
        private static string? dbPath;

        public static void Initialize(string? databasePath = null)
        {
            if (!string.IsNullOrWhiteSpace(databasePath))
                dbPath = databasePath;

            if (string.IsNullOrWhiteSpace(dbPath))
                dbPath = DatabaseConfig.DatabasePath;

            using var connection =
                new SqliteConnection($"Data Source={dbPath}");

            connection.Open();

            using var cmd = connection.CreateCommand();

            cmd.CommandText =
            @"
            CREATE TABLE IF NOT EXISTS ArtistProfile (
                ArtistId INTEGER PRIMARY KEY,
                ArtistEmail TEXT NOT NULL,
                ArtistBio TEXT,
                TosExpectations TEXT,
                TosWillDraw TEXT,
                TosWontDraw TEXT
            );
            ";

            cmd.ExecuteNonQuery();

            // Create default profile if none exists
            cmd.CommandText =
            @"
            INSERT OR IGNORE INTO ArtistProfile (
                ArtistId,
                ArtistEmail,
                ArtistBio,
                TosExpectations,
                TosWillDraw,
                TosWontDraw
            )
            VALUES
            (
                1,
                '',
                '',
                '',
                '',
                ''
            );
            ";

            cmd.ExecuteNonQuery();
        }

        public static ArtistInformation GetArtistProfile()
        {
            if (string.IsNullOrWhiteSpace(dbPath))
                Initialize();

            using var connection =
                new SqliteConnection($"Data Source={dbPath}");

            connection.Open();

            using var cmd = connection.CreateCommand();

            cmd.CommandText =
            "SELECT * FROM ArtistProfile WHERE ArtistId = 1;";

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
            {
                return new ArtistInformation
                {
                    ArtistId = 1
                };
            }

            return new ArtistInformation
            {
                ArtistId = reader.GetInt32(0),
                ArtistEmail = reader.GetString(1),

                ArtistBio =
                    reader.IsDBNull(2)
                    ? string.Empty
                    : reader.GetString(2),

                TosExpectations =
                    reader.IsDBNull(3)
                    ? string.Empty
                    : reader.GetString(3),

                TosWillDraw =
                    reader.IsDBNull(4)
                    ? string.Empty
                    : reader.GetString(4),

                TosWontDraw =
                    reader.IsDBNull(5)
                    ? string.Empty
                    : reader.GetString(5)
            };
        }

        public static void UpdateArtistProfile(
            ArtistInformation profile)
        {
            if (profile == null)
                throw new ArgumentNullException(nameof(profile));

            if (string.IsNullOrWhiteSpace(dbPath))
                Initialize();

            using var connection =
                new SqliteConnection($"Data Source={dbPath}");

            connection.Open();

            using var cmd = connection.CreateCommand();

            cmd.CommandText =
            @"
            UPDATE ArtistProfile
            SET
                ArtistEmail = $email,
                ArtistBio = $bio,
                TosExpectations = $expectations,
                TosWillDraw = $willdraw,
                TosWontDraw = $wontdraw
            WHERE ArtistId = 1;
            ";

            cmd.Parameters.AddWithValue(
                "$email",
                profile.ArtistEmail);

            cmd.Parameters.AddWithValue(
                "$bio",
                profile.ArtistBio);

            cmd.Parameters.AddWithValue(
                "$expectations",
                profile.TosExpectations);

            cmd.Parameters.AddWithValue(
                "$willdraw",
                profile.TosWillDraw);

            cmd.Parameters.AddWithValue(
                "$wontdraw",
                profile.TosWontDraw);

            cmd.ExecuteNonQuery();
        }

        public static string GetDatabasePath()
        {
            if (string.IsNullOrWhiteSpace(dbPath))
                Initialize();

            return dbPath!;
        }
    }
}