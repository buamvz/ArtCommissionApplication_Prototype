using System;
using System.Collections.Generic;
using System.Text;

namespace ArtCommissionApplication_Prototype
{
    public class SessionManager
    {
        public static User LoggedInUser { get; private set; }
        public static void SetUser(User user)
        {
            LoggedInUser = user;
        }
        public static void Logout()
        {
            LoggedInUser = null;
        }
    }
}
