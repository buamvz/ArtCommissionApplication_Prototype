using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ArtCommissionApplication_Prototype
{
    public class User
    {

        [Key]
        [Required]
        [StringLength(20)]
        public string Username { get; set; }

        public int PermissionLevel { get; set; } = 0;
    }
}
