using System;
using System.Collections.Generic;
using System.Text;

namespace ArtCommissionApplication_Prototype
{
    public class SessionManager
    {
        // sienna - changed "logged in user" to "current active user" to avoid confusion as this is simply the currently active user in the session, not necessarily logged in.
        public static User CurrentActiveUser { get; private set; }

        // Event raised when the current user changes. UI can subscribe to update views.
        public static event Action<User?>? UserChanged;

        public static void SetUser(User user)
        {
            CurrentActiveUser = user;
            UserChanged?.Invoke(CurrentActiveUser);
        }

        public static void Logout()
        {
            CurrentActiveUser = null;
            UserChanged?.Invoke(null);
        }

        public static bool IsClient() => CurrentActiveUser != null && CurrentActiveUser.Role == SystemRole.Client;
        public static bool IsArtist() => CurrentActiveUser != null && CurrentActiveUser.Role == SystemRole.Artist;
        public static bool IsAdmin() => CurrentActiveUser != null && CurrentActiveUser.Role == SystemRole.Admin;

        // Attempt to login with existing username/password - Returns true if successful.
        public static bool Login(string username, string password, SystemRole role)
        {
            if (string.IsNullOrWhiteSpace(username) || password == null)
                return false;

            try
            {
                UserRepository.Initialize();
                var user = UserRepository.Authenticate(username, password, role);
                if (user == null) return false;

                SetUser(user);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Sign up a new user - Returns true on success and signs the user in.
        public static bool SignUp(string username, string password, SystemRole role)
        {
            if (string.IsNullOrWhiteSpace(username) || password == null)
                return false;

            try
            {
                UserRepository.Initialize();
                var created = UserRepository.CreateUser(username, password, role);
                if (created == null) return false;
                SetUser(created);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
