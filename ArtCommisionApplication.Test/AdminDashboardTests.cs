using System.Globalization;
using ArtCommissionApplication_Prototype;
using Microsoft.Data.Sqlite;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static ArtCommissionApplication_Prototype.CommissionInformation;


namespace ArtCommisionApplication.Test
{
    [TestClass]
    [DoNotParallelize]
    public class AdminDashboardTests
    {
        [TestInitialize]
        public void Initialize()
        {
            // Ensure session state is cleared before each test to avoid cross-test contamination.
            SessionManager.Logout();
        }

        [TestCleanup]
        public void Cleanup()
        {
            SessionManager.Logout();
        }


        [TestMethod]
        public void SetUser_AdminRole_IsRecognisedAsAdmin()
        {
            var admin = new User
            {
                Username = "Admin",
                Role = SystemRole.Admin
            };

            SessionManager.SetUser(admin);

            Assert.IsTrue(SessionManager.IsAdmin());
            Assert.IsFalse(SessionManager.IsClient());
            Assert.IsFalse(SessionManager.IsArtist());
        }

        [TestMethod]
        public void SetUser_ClientRole_IsNotRecognisedAsAdmin()
        {
            var client = new User
            {
                Username = "testclient",
                Role = SystemRole.Client
            };

            SessionManager.SetUser(client);

            Assert.IsFalse(SessionManager.IsAdmin());
            Assert.IsTrue(SessionManager.IsClient());
        }

        [TestMethod]
        public void Admin_AccessAllowed()
        {
            var admin = new User
            {
                Username = "unit_test_admin",
                Role = SystemRole.Admin
            };

            SessionManager.SetUser(admin);

            Assert.IsTrue(SessionManager.IsAdmin(), "Admin should be recognised as admin for access checks.");
        }

        [TestMethod]
        public void Client_AccessDenied()
        {
            var client = new User
            {
                Username = "unit_test_client",
                Role = SystemRole.Client
            };

            SessionManager.SetUser(client);

            Assert.IsFalse(SessionManager.IsAdmin(), "Client must not be allowed admin access.");
        }

        [TestMethod]
        public void Artist_AccessDenied()
        {
            var artist = new User
            {
                Username = "unit_test_artist",
                Role = SystemRole.Artist
            };

            SessionManager.SetUser(artist);

            Assert.IsFalse(SessionManager.IsAdmin(), "Artist must not be allowed admin access.");
        }

        [TestMethod]
        public void Unauthenticated_AccessDenied()
        {
            SessionManager.Logout();

            Assert.IsFalse(SessionManager.IsAdmin(), "Unauthenticated users must not be allowed admin access.");
        }

        [TestMethod]
        public void Statistics_EmptyDatabase()
        {
            string testDatabasePath = Path.Combine(
                Path.GetTempPath(),
                Guid.NewGuid().ToString() + ".db");
            try
            {
                CommissionRepository.Initialize(testDatabasePath);

                var stats = AdminDashboardStatisticsService.Calculate();

                Assert.AreEqual(0, stats.TotalCommissions);
                Assert.AreEqual(0, stats.ActiveCommissions);
                Assert.AreEqual(0, stats.CompletedCommissions);
                Assert.AreEqual(0, stats.OverdueCommissions);
            }
            finally
            {
                try { System.IO.File.Delete(testDatabasePath); } catch { }
            }
        }

        [TestMethod]
        public void Statistics_MixedStatusesAndDeadlines()
        {
            string testDatabasePath = Path.Combine(
                Path.GetTempPath(),
                $"ArtCommissionTest_{Guid.NewGuid()}.db");
            try
            {
                CommissionRepository.Initialize(testDatabasePath);

            // Create commissions (all initially with need-by in the future to satisfy validation)
            var client = new Client("A", "a@example.com");

            var c1 = new CommissionRequest(client, new CommissionInformation(CharacterCrop.Headshot, 1, false, "one", DateTime.Today.AddDays(7)));
            CommissionRepository.AddCommission(c1); // pending

            var c2 = new CommissionRequest(client, new CommissionInformation(CharacterCrop.Headshot, 1, false, "two", DateTime.Today.AddDays(7)));
            CommissionRepository.AddCommission(c2);
            CommissionRepository.UpdateStatus(c2.Id, CommissionStatus.Accepted);

            var c3 = new CommissionRequest(client, new CommissionInformation(CharacterCrop.Headshot, 1, false, "three", DateTime.Today.AddDays(7)));
            CommissionRepository.AddCommission(c3);
            CommissionRepository.UpdateStatus(c3.Id, CommissionStatus.InProgress);

            var c4 = new CommissionRequest(client, new CommissionInformation(CharacterCrop.Headshot, 1, false, "four", DateTime.Today.AddDays(7)));
            CommissionRepository.AddCommission(c4);
            CommissionRepository.UpdateStatus(c4.Id, CommissionStatus.Completed);

            var c5 = new CommissionRequest(client, new CommissionInformation(CharacterCrop.Headshot, 1, false, "five", DateTime.Today.AddDays(7)));
            CommissionRepository.AddCommission(c5);
            CommissionRepository.UpdateStatus(c5.Id, CommissionStatus.Rejected);

            var c6 = new CommissionRequest(client, new CommissionInformation(CharacterCrop.Headshot, 1, false, "six", DateTime.Today.AddDays(7)));
            CommissionRepository.AddCommission(c6);
            // keep c6 pending but make it overdue by editing DB directly

            // Make c4 and c5 and c6 have specific NeedByDate values: c4 completed yesterday, c5 rejected yesterday, c6 pending yesterday
            var yesterday = DateTime.Today.AddDays(-1);

            using (var conn = new SqliteConnection($"Data Source={testDatabasePath}"))
            {
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Commissions SET NeedByDate = $need WHERE Id IN ($id4,$id5,$id6);";
                cmd.Parameters.AddWithValue("$need", yesterday.ToString("o", CultureInfo.InvariantCulture));
                cmd.Parameters.AddWithValue("$id4", c4.Id);
                cmd.Parameters.AddWithValue("$id5", c5.Id);
                cmd.Parameters.AddWithValue("$id6", c6.Id);
                cmd.ExecuteNonQuery();
            }

            var stats = AdminDashboardStatisticsService.Calculate();

            // total 6
            Assert.AreEqual(6, stats.TotalCommissions);
            // active: c2 (Accepted) + c3 (InProgress)
            Assert.AreEqual(2, stats.ActiveCommissions);
            // completed: c4
            Assert.AreEqual(1, stats.CompletedCommissions);
            // overdue: c6 only (pending and due yesterday). c4 is completed (excluded), c5 is rejected (excluded)
            Assert.AreEqual(1, stats.OverdueCommissions);
            }
            finally
            {
                try { System.IO.File.Delete(testDatabasePath); } catch { }
            }
        }
    }
}