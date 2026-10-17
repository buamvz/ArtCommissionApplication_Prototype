using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace ArtCommissionApplication_Prototype
{
    public static class NotificationRepository
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
            CREATE TABLE IF NOT EXISTS Notifications
            (
                NotificationId INTEGER PRIMARY KEY AUTOINCREMENT,
                Username TEXT NOT NULL,
                Message TEXT NOT NULL,
                IsRead INTEGER NOT NULL DEFAULT 0
            );
            ";

            cmd.ExecuteNonQuery();
        }

        public static void AddNotification(
            string username,
            string message)
        {
            if (string.IsNullOrWhiteSpace(dbPath))
                Initialize();

            using var connection =
                new SqliteConnection($"Data Source={dbPath}");

            connection.Open();

            using var cmd = connection.CreateCommand();

            cmd.CommandText =
            @"
            INSERT INTO Notifications
            (
                Username,
                Message,
                IsRead
            )
            VALUES
            (
                $username,
                $message,
                0
            );
            ";

            cmd.Parameters.AddWithValue(
                "$username",
                username);

            cmd.Parameters.AddWithValue(
                "$message",
                message);

            cmd.ExecuteNonQuery();
        }

        public static List<Notification> GetUnreadNotifications(
            string username)
        {
            if (string.IsNullOrWhiteSpace(dbPath))
                Initialize();

            List<Notification> notifications = new();

            using var connection =
                new SqliteConnection($"Data Source={dbPath}");

            connection.Open();

            using var cmd = connection.CreateCommand();

            cmd.CommandText =
            @"
            SELECT
                NotificationId,
                Username,
                Message,
                IsRead
            FROM Notifications
            WHERE Username = $username
            AND IsRead = 0;
            ";

            cmd.Parameters.AddWithValue(
                "$username",
                username);

            using var reader =
                cmd.ExecuteReader();

            while (reader.Read())
            {
                notifications.Add(
                    new Notification
                    {
                        NotificationId =
                            reader.GetInt32(0),

                        Username =
                            reader.GetString(1),

                        Message =
                            reader.GetString(2),

                        IsRead =
                            reader.GetInt32(3) == 1
                    });
            }

            return notifications;
        }

        public static void MarkNotificationAsRead(
            int notificationId)
        {
            if (string.IsNullOrWhiteSpace(dbPath))
                Initialize();

            using var connection =
                new SqliteConnection($"Data Source={dbPath}");

            connection.Open();

            using var cmd = connection.CreateCommand();

            cmd.CommandText =
            @"
            UPDATE Notifications
            SET IsRead = 1
            WHERE NotificationId = $id;
            ";

            cmd.Parameters.AddWithValue(
                "$id",
                notificationId);

            cmd.ExecuteNonQuery();
        }

        public static void MarkAllAsRead(
            string username)
        {
            if (string.IsNullOrWhiteSpace(dbPath))
                Initialize();

            using var connection =
                new SqliteConnection($"Data Source={dbPath}");

            connection.Open();

            using var cmd = connection.CreateCommand();

            cmd.CommandText =
            @"
            UPDATE Notifications
            SET IsRead = 1
            WHERE Username = $username;
            ";

            cmd.Parameters.AddWithValue(
                "$username",
                username);

            cmd.ExecuteNonQuery();
        }
    }
}