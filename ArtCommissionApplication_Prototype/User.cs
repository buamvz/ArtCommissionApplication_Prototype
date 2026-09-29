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
        public Role Role { get; set; } = Role.Client;

        // Backwards-compatible permission level (optional). Prefer Role.
        public int PermissionLevel { get; set; } = 0;
    }

    public enum Role
    {
        Client = 0,
        Artist = 1,
        Admin = 2
    }
}
