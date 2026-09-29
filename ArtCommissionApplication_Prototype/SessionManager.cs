using System;
using System.Collections.Generic;
using System.Text;

namespace ArtCommissionApplication_Prototype
{
    public class SessionManager
    {
        public static User LoggedInUser { get; private set; }

        // Event raised when the current user changes. UI can subscribe to update views.
        public static event Action<User?>? UserChanged;

        public static void SetUser(User user)
        {
            LoggedInUser = user;
            UserChanged?.Invoke(LoggedInUser);
        }

        public static void Logout()
        {
            LoggedInUser = null;
            UserChanged?.Invoke(null);
        }

        public static bool IsClient() => LoggedInUser != null && LoggedInUser.Role == Role.Client;
        public static bool IsArtist() => LoggedInUser != null && LoggedInUser.Role == Role.Artist;
        public static bool IsAdmin() => LoggedInUser != null && LoggedInUser.Role == Role.Admin;
    }
}
