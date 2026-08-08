using System;
using System.Collections.Generic;
using System.Text;

namespace ArtCommissionApplication_Prototype
{
    //instead of using string get and sets having a emun
    //an emun restricts the status to values that are defined
    //adds maintainability + reliability
    public enum CommissionStatus
    {
        Pending,
        Accepted,
        Rejected,
        InProgress,
        Completed
    }
}
