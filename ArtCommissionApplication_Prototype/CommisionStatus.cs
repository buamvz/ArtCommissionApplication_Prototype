using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ArtCommissionApplication_Prototype
{
    //instead of using string get and sets having a emun
    //an emun restricts the status to values that are defined
    //adds maintainability + reliability
    public enum CommissionStatus
    {
        // sienna - added display names to be in the public queue
        [Display(Name = "Pending")]
        Pending,

        [Display(Name = "Accepted")]
        Accepted,

        [Display(Name = "Rejected")]
        Rejected,

        [Display(Name = "In Progress")]
        InProgress,

        [Display(Name = "Completed")]
        Completed
    }
}
