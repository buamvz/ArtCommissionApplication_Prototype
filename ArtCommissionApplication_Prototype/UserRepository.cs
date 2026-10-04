using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Data.Sqlite;

namespace ArtCommissionApplication_Prototype
{
    // Simple user repository using the same SQLite file as commissions.
    public static class UserRepository
    {
        private static string? dbPath;

        public static void Initialize(string? databasePath = null)
        {
            if (!string.IsNullOrWhiteSpace(databasePath))
                dbPath = databasePath;

            if (string.IsNullOrWhiteSpace(dbPath))
                dbPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "commissions.db");

            using var connection = new SqliteConnection($"Data Source={dbPath}");
            connection.Open();

            using var cmd = connection.CreateCommand();
            cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS Users (
    Username TEXT PRIMARY KEY,
    PasswordHash TEXT NOT NULL,
    PasswordSalt TEXT NOT NULL,
    Role INTEGER NOT NULL,
    PermissionLevel INTEGER NOT NULL
);
";
            cmd.ExecuteNonQuery();
        }

        public static User? GetUserByUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(dbPath)) Initialize();

            using var connection = new SqliteConnection($"Data Source={dbPath}");
            connection.Open();

            using var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Username, PasswordHash, PasswordSalt, Role, PermissionLevel FROM Users WHERE Username = $u LIMIT 1;";
            cmd.Parameters.AddWithValue("$u", username);

            using var reader = cmd.ExecuteReader();
            if (!reader.Read()) return null;

            var user = new User
            {
                Username = reader.GetString(0),
                PasswordHash = reader.GetString(1),
                PasswordSalt = reader.GetString(2),
                Role = (SystemRole)reader.GetInt32(3),
                PermissionLevel = reader.GetInt32(4)
            };

            return user;
        }

        public static IEnumerable<User> GetAllUsers()
        {
            if (string.IsNullOrWhiteSpace(dbPath)) Initialize();

            var list = new List<User>();
            using var connection = new SqliteConnection($"Data Source={dbPath}");
            connection.Open();

            using var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Username, PasswordHash, PasswordSalt, Role, PermissionLevel FROM Users ORDER BY Username;";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new User
                {
                    Username = reader.GetString(0),
                    PasswordHash = reader.GetString(1),
                    PasswordSalt = reader.GetString(2),
                    Role = (SystemRole)reader.GetInt32(3),
                    PermissionLevel = reader.GetInt32(4)
                });
            }

            return list;
        }

        // Create a new user. Enforces that only one Artist and one Admin can exist.
        // sienna - only one artist and admin can exist for this application, while multiple clients can exist. 
        // the system enforces this so multiple artists can't be created.
        public static User CreateUser(string username, string password, SystemRole role, int permissionLevel = 0)
        {
            if (string.IsNullOrWhiteSpace(username)) throw new ArgumentException("username");
            if (password == null) throw new ArgumentNullException(nameof(password));

            if (string.IsNullOrWhiteSpace(dbPath)) Initialize();

            // if role is Artist or Admin, ensure no existing user has that role
            if (role == SystemRole.Artist || role == SystemRole.Admin)
            {
                using var connection = new SqliteConnection($"Data Source={dbPath}");
                connection.Open();
                using var checkCmd = connection.CreateCommand();
                checkCmd.CommandText = "SELECT COUNT(1) FROM Users WHERE Role = $role;";
                checkCmd.Parameters.AddWithValue("$role", (int)role);
                var count = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (count > 0)
                    throw new InvalidOperationException($"A user with role {role} already exists.");
            }

            // create password salt & hash
            // sienna - hash stores the password into a hash value instead of plain text to keep it more secure.
            // - salt is a random value added to the password befor the hash to further secure it against attacks like "rainbow tables".
            var salt = new byte[16];
            RandomNumberGenerator.Fill(salt);
            var hash = HashPassword(password, salt);

            using var conn = new SqliteConnection($"Data Source={dbPath}");
            conn.Open();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO Users (Username, PasswordHash, PasswordSalt, Role, PermissionLevel) VALUES ($u, $hash, $salt, $role, $perm);";
            cmd.Parameters.AddWithValue("$u", username);
            cmd.Parameters.AddWithValue("$hash", Convert.ToBase64String(hash));
            cmd.Parameters.AddWithValue("$salt", Convert.ToBase64String(salt));
            cmd.Parameters.AddWithValue("$role", (int)role);
            cmd.Parameters.AddWithValue("$perm", permissionLevel);
            cmd.ExecuteNonQuery();

            return GetUserByUsername(username)!;
        }

        // sienna - compare a given username and password to the stored hash and salt and returns a user (only after clearing the hash and salt so they are not exposed)
        public static User? Authenticate(string username, string password, SystemRole role)
        {
            var user = GetUserByUsername(username);
            if (user == null) return null;

            if (user.Role != role)
                return null;

            if (string.IsNullOrEmpty(user.PasswordSalt) || string.IsNullOrEmpty(user.PasswordHash))
                return null;

            var salt = Convert.FromBase64String(user.PasswordSalt);
            var expectedHash = Convert.FromBase64String(user.PasswordHash);
            var actualHash = HashPassword(password, salt);

            if (FixedTimeEquals(expectedHash, actualHash))
            {
                // don't expose hash values beyond repository
                user.PasswordHash = null;
                user.PasswordSalt = null;
                return user;
            }

            return null;
        }

        private static byte[] HashPassword(string password, byte[] salt)
        {
            using var derive = new Rfc2898DeriveBytes(password, salt, 100_000, HashAlgorithmName.SHA256);
            return derive.GetBytes(32);
        }

        // sienna - prevent timing attacks by making sure the comparison takes the same time regardless of bytes matching or not.
        private static bool FixedTimeEquals(byte[] a, byte[] b)
        {
            if (a == null || b == null) return false;
            if (a.Length != b.Length) return false;
            int diff = 0;
            for (int i = 0; i < a.Length; i++) diff |= a[i] ^ b[i];
            return diff == 0;
        }
    }
}
