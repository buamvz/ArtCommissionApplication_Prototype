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
    }
}