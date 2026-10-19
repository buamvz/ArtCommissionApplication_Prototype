using ArtCommisionApplication;
using ArtCommissionApplication_Prototype;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using static ArtCommissionApplication_Prototype.CommissionInformation;
using Microsoft.Data.Sqlite;
using System.IO;
using System.Globalization;


namespace ArtCommisionApplication.Test
{
    [TestClass]
    [DoNotParallelize]
    public class CommissionRequestTests
    {
        // sienna - switching to a test user database
        private string testUserDatabasePath;

        [TestInitialize]
        public void TestInitialize()
        {
            testUserDatabasePath = Path.Combine(
                Path.GetTempPath(),
                $"UserTest_{Guid.NewGuid()}.db");

            UserRepository.Initialize(testUserDatabasePath);

            SessionManager.Logout();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            SessionManager.Logout();

            try
            {
                if (File.Exists(testUserDatabasePath))
                    File.Delete(testUserDatabasePath);
            }
            catch
            {
                // ignore cleanup failures
            }
        }


        [TestMethod]
        public void Client_EmptyClientName_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new Client("", "mahitohater67@gmail.com"));
        }

        [TestMethod]
        public void Client_EmptyClientEmail_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new Client("Yuji", ""));
        }

        [TestMethod]
        public void CommissionRequest_ValidDetails_CreatesPendingRequest()
        {
            var client = new Client("Yuji", "mahitohater67@gmail.com");
            var commission = new CommissionInformation(CharacterCrop.Fullbody, 2, true, "Me and Junpei having a picnic", DateTime.Today.AddDays(8));

            var request = new CommissionRequest(client, commission);

            Assert.AreEqual(CommissionStatus.Pending, request.Status);
        }

        [TestMethod]
        public void CommissionRequest_EmptyDescription_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new CommissionInformation(CharacterCrop.Fullbody, 2, true, "", DateTime.Today.AddDays(8)));

        }

        // Brooke - checking a past date 
        //past date will be rejected (business rule defect prevention) 
        //vaild future date will be accepted

        [TestMethod]
        public void CommissionInformation_PastNeedByDate_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new CommissionInformation(CharacterCrop.Fullbody, 2, true, "Me and Junpei having a picnic", DateTime.Today.AddDays(-1)));
        }

        [TestMethod]
        public void CommissionInformation_FutureNeedByDate_CreatesCommission()
        {
            var commission = new CommissionInformation(CharacterCrop.Fullbody, 2, true, "Me and Junpei having a picnic", DateTime.Today.AddDays(7));

            Assert.AreEqual(DateTime.Today.AddDays(7), commission.NeedByDate.Value.Date);
        }

        //invaild and vaild email test for new mailAddress in client
        [TestMethod]
        public void Client_InvalidEmail_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new Client("Yuji", "noemailhere"));
        }

        [TestMethod]
        public void Client_ValidEmail_CreatesClient()
        {
            var client = new Client("Yuji", "mahitohater67@gmail.com");

            Assert.AreEqual("Yuji", client.ClientName);
            Assert.AreEqual("mahitohater67@gmail.com", client.ClientEmail);
        }

        [TestMethod]
        public void CommissionInformation_MoreThanFiveCharacters_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new CommissionInformation(CharacterCrop.Fullbody, 6, true, "Me and Junpei having a picnic", DateTime.Today.AddDays(7)));
        }

        [TestMethod]
        public void CommissionInformation_ZeroCharacters_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new CommissionInformation(CharacterCrop.Fullbody, 0, true, "Me and Junpei having a picnic", DateTime.Today.AddDays(7)));
        }

        [TestMethod]
        public void CommissionInformation_OneCharacter_CreatesCommission()
        {
            var commission = new CommissionInformation(CharacterCrop.Headshot, 1, false, "A", DateTime.Today.AddDays(7));

            Assert.AreEqual(1, commission.NumberOFCharacters);
        }

        [TestMethod]
        public void CommissionInformation_FiveCharacters_CreatesCommission()
        {
            var commission = new CommissionInformation(CharacterCrop.Fullbody, 5, true, "Group of five", DateTime.Today.AddDays(7));

            Assert.AreEqual(5, commission.NumberOFCharacters);
        }

        [TestMethod]
        public void CommissionInformation_NegativeCharacters_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new CommissionInformation(CharacterCrop.Halfbody, -1, false, "Invalid negative", DateTime.Today.AddDays(7)));
        }

        //queue prototype test
        [TestMethod]
        public void CommissionQueue_AddCommission_AddsToQueue()
        {
            var client = new Client("Yuji", "mahitohater67@gmail.com");

            var commission = new CommissionInformation(CommissionInformation.CharacterCrop.Fullbody, 2, true, "Me and Junpei having a picnic", DateTime.Today.AddDays(7));

            var request = new CommissionRequest(client, commission);

            var queue = new CommissionQueue();

            queue.AddCommission(request);

            Assert.AreEqual(1, queue.Count);
        }

        [TestMethod]
        public void CommissionQueue_GetQueuePosition_ReturnsCorrectPosition()
        {
            var client1 = new Client("Yuji", "yuji@example.com");
            var commission1 = new CommissionInformation(CommissionInformation.CharacterCrop.Headshot, 1, false, "First commission", DateTime.Today.AddDays(7));

            var client2 = new Client("Megumi", "megumi@example.com");
            var commission2 = new CommissionInformation(CommissionInformation.CharacterCrop.Fullbody, 1, true, "Second commission", DateTime.Today.AddDays(7));

            var request1 = new CommissionRequest(client1, commission1);
            var request2 = new CommissionRequest(client2, commission2);

            var queue = new CommissionQueue();

            queue.AddCommission(request1);
            queue.AddCommission(request2);

            Assert.AreEqual(1, queue.GetQueuePosition(request1));
            Assert.AreEqual(2, queue.GetQueuePosition(request2));
        }

        //testing database and queue intergration for loading a commission from new database Sienna made

        [TestMethod]
        public void CommissionQueue_LoadFromDatabase_LoadsStoredCommissions()
        {
            string testDatabasePath = System.IO.Path.Combine(
                System.IO.Path.GetTempPath(),
                Guid.NewGuid().ToString() + ".db");

            CommissionRepository.Initialize(testDatabasePath);

            var client = new Client(
                "Yuji",
                "yuji@gmail.com");

            var commission = new CommissionInformation(
                CharacterCrop.Fullbody,
                2,
                true,
                "Me and Junpei having a picnic",
                DateTime.Today.AddDays(7));

            var request = new CommissionRequest(
                client,
                commission);

            CommissionRepository.AddCommission(request);

            var queue = new CommissionQueue();

            queue.LoadFromDatabase();

            Assert.AreEqual(1, queue.Count);
            Assert.AreEqual(
                "Yuji",
                queue.Commissions[0].Client.ClientName);
        }

        [TestMethod]
        public void Constructor_Throws_On_Invalid_Email()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                var c = new Client("Name", "not-an-email");
            });
        }

        [TestMethod]
        public void Constructor_Allows_Valid_Email()
        {
            var c = new Client("Name", "example@example.com");
            Assert.AreEqual("Name", c.ClientName);
            Assert.AreEqual("example@example.com", c.ClientEmail);
        }

        //test cases for siennas sign up and login system - Brooke
        //sign up creates a client
        [TestMethod]
        public void SignUp_ValidClient_CreatesClient()
        {
            string username =
                "testclient" + Guid.NewGuid().ToString("N").Substring(0, 8);

            string password = "Password123";

            User user = UserRepository.CreateUser(
                username,
                password,
                SystemRole.Client);

            Assert.IsNotNull(user);
            Assert.AreEqual(username, user.Username);
            Assert.AreEqual(SystemRole.Client, user.Role);
        }

        //valid logins succedding
        [TestMethod]
        public void Login_ValidCredentials_ReturnsTrue()
        {
            string username =
                "loginuser" + Guid.NewGuid().ToString("N").Substring(0, 8);

            string password = "Password123";

            UserRepository.CreateUser(
                username,
                password,
                SystemRole.Client);

            var user = UserRepository.Authenticate(
                username,
                password,
                SystemRole.Client);

            Assert.IsNotNull(user);

            SessionManager.SetUser(user);

            Assert.IsNotNull(SessionManager.CurrentActiveUser);
            Assert.AreEqual(
                username,
                SessionManager.CurrentActiveUser.Username);
        }

        //wrong password will fail
        [TestMethod]
        public void Login_WrongPassword_ReturnsFalse()
        {
            string username =
                "wrongpass" + Guid.NewGuid().ToString("N").Substring(0, 8);

            UserRepository.CreateUser(
                username,
                "CorrectPassword123",
                SystemRole.Client);

            var user = UserRepository.Authenticate(
                username,
                "WrongPassword123",
                SystemRole.Client);

            Assert.IsNull(user);
        }

        //incorrect role will fail
        [TestMethod]
        public void Login_WrongRole_ReturnsFalse()
        {
            string username =
                "roleuser" + Guid.NewGuid().ToString("N").Substring(0, 8);

            UserRepository.CreateUser(
                username,
                "Password123",
                SystemRole.Client);

            var user = UserRepository.Authenticate(
                username,
                "Password123",
                SystemRole.Artist);

            Assert.IsNull(user);
        }


        //logout clears/kicks current user
        [TestMethod]
        public void Logout_ClearsCurrentUser()
        {
            string username =
                "logoutuser" + Guid.NewGuid().ToString("N").Substring(0, 8);

            UserRepository.CreateUser(
                username,
                "Password123",
                SystemRole.Client);

            var user = UserRepository.Authenticate(
                username,
                "Password123",
                SystemRole.Client);

            Assert.IsNotNull(user);

            SessionManager.SetUser(user);

            SessionManager.Logout();

            Assert.IsNull(SessionManager.CurrentActiveUser);
        }

        [TestMethod]
        public void CommissionRepository_LoadFromDatabase_PreservesStatus()
        {
            string testDatabasePath = System.IO.Path.Combine(
                System.IO.Path.GetTempPath(),
                Guid.NewGuid().ToString() + ".db");

            CommissionRepository.Initialize(testDatabasePath);

            var client = new Client(
                "Yuji",
                "yuji@example.com");

            var commission = new CommissionInformation(
                CharacterCrop.Fullbody,
                2,
                true,
                "Test commission",
                DateTime.Today.AddDays(7));

            var request = new CommissionRequest(client, commission);

            CommissionRepository.AddCommission(request);

            CommissionRepository.UpdateStatus(
                request.Id,
                CommissionStatus.Accepted);

            var commissions = CommissionRepository.GetAll();

            Assert.AreEqual(
                CommissionStatus.Accepted,
                commissions[0].Status);
        }

        [TestMethod]
        public void CommissionRepository_Loads_OldDeadline_PreservesFields()
        {
            string testDatabasePath = Path.Combine(
                Path.GetTempPath(),
                Guid.NewGuid().ToString() + ".db");

            try
            {
                CommissionRepository.Initialize(testDatabasePath);

                var client = new Client("Yuji", "yuji@example.com");
                var commission = new CommissionInformation(
                    CharacterCrop.Fullbody,
                    2,
                    true,
                    "Test commission",
                    DateTime.Today.AddDays(7));

                var request = new CommissionRequest(client, commission);
                CommissionRepository.AddCommission(request);

                // Modify stored row to simulate an old deadline and preserved price/submitted date
                var yesterday = DateTime.Today.AddDays(-1);
                var storedSubmitted = new DateTime(2020, 1, 2, 3, 4, 5, DateTimeKind.Utc);
                var storedPrice = 123.45m;
                var storedStatus = (int)CommissionStatus.Accepted;

                using (var conn = new SqliteConnection($"Data Source={testDatabasePath}"))
                {
                    conn.Open();
                    using var cmd = conn.CreateCommand();
                    cmd.CommandText = "UPDATE Commissions SET NeedByDate = $need, SubmittedDate = $submitted, EstimatedPrice = $price, Status = $status WHERE Id = $id;";
                    cmd.Parameters.AddWithValue("$need", yesterday.ToString("o", CultureInfo.InvariantCulture));
                    cmd.Parameters.AddWithValue("$submitted", storedSubmitted.ToString("o", CultureInfo.InvariantCulture));
                    cmd.Parameters.AddWithValue("$price", (double)storedPrice);
                    cmd.Parameters.AddWithValue("$status", storedStatus);
                    cmd.Parameters.AddWithValue("$id", request.Id);
                    cmd.ExecuteNonQuery();
                }

                var commissions = CommissionRepository.GetAll();
                Assert.AreEqual(1, commissions.Count);
                var loaded = commissions[0];

                Assert.IsNotNull(loaded.CommissionType.NeedByDate);
                Assert.AreEqual(yesterday.Date, loaded.CommissionType.NeedByDate.Value.Date);

                // SubmittedDate should be preserved
                Assert.AreEqual(storedSubmitted, loaded.SubmittedDate.ToUniversalTime());

                // Estimated price preserved
                Assert.AreEqual(storedPrice, loaded.EstimatedPrice);

                // Status preserved
                Assert.AreEqual(CommissionStatus.Accepted, loaded.Status);
            }
            finally
            {
                try { System.IO.File.Delete(testDatabasePath); } catch { }
            }
        }

        [TestMethod]
        public void CommissionRepository_Loads_NullDeadline()
        {
            string testDatabasePath = Path.Combine(
                Path.GetTempPath(),
                Guid.NewGuid().ToString() + ".db");

            try
            {
                CommissionRepository.Initialize(testDatabasePath);

                var client = new Client("Yuji", "yuji@example.com");
                var commission = new CommissionInformation(
                    CharacterCrop.Fullbody,
                    2,
                    true,
                    "Test commission",
                    DateTime.Today.AddDays(7));

                var request = new CommissionRequest(client, commission);
                CommissionRepository.AddCommission(request);

                // Set NeedByDate to empty string to represent null in DB
                using (var conn = new SqliteConnection($"Data Source={testDatabasePath}"))
                {
                    conn.Open();
                    using var cmd = conn.CreateCommand();
                    cmd.CommandText = "UPDATE Commissions SET NeedByDate = $need WHERE Id = $id;";
                    cmd.Parameters.AddWithValue("$need", string.Empty);
                    cmd.Parameters.AddWithValue("$id", request.Id);
                    cmd.ExecuteNonQuery();
                }

                var commissions = CommissionRepository.GetAll();
                Assert.AreEqual(1, commissions.Count);
                var loaded = commissions[0];

                Assert.IsNull(loaded.CommissionType.NeedByDate);
            }
            finally
            {
                try { System.IO.File.Delete(testDatabasePath); } catch { }
            }
        }

        
    }


}
