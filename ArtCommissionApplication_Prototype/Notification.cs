using System;
using System.Collections.Generic;
using System.Text;

namespace ArtCommissionApplication_Prototype
{
    // sienna - piecing together a notification system with database
    public class Notification
    {
        public int NotificationId { get; set; }

        public string Username { get; set; } = string.Empty;

        public string Message { get; set; } = string.Empty;

        public bool IsRead { get; set; }
    }
}
