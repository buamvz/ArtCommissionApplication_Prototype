using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ArtCommissionApplication_Prototype
{
    public class User
    {
        // Core identity for role-based access
        [Key]
        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        // Role assigned to the user (Client, Artist, Admin)
        public SystemRole Role { get; set; } = SystemRole.Client;

        // Backwards-compatible permission level (optional). Prefer Role.
        public int PermissionLevel { get; set; } = 0;

        // Stored password hash (base64). Only used for authentication storage.
        public string? PasswordHash { get; set; }

        // Stored password salt (base64).
        public string? PasswordSalt { get; set; }
    }

    public enum SystemRole
    {
        Client = 0,
        Artist = 1,
        Admin = 2
    }
}
