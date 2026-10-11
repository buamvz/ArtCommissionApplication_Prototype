using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArtCommissionApplication_Prototype;


namespace ArtCommisionApplication.Test
{
    [TestClass]
    public class AdminDashboardTests
    {
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
                Username = "testadmin",
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
    }
}