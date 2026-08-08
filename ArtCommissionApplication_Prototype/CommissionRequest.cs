using System;
using System.Collections.Generic;
using System.Text;

namespace ArtCommissionApplication_Prototype
{
    public class CommissionRequest
    {
        public string Id { get; }
        public string ClientName { get; }
        public string ClientEmail { get; }
        public string CommisionType { get; }
        public string Discription { get; }
        public string EstimatedPrice { get; }
        public CommissionStatus Status { get; set; }
        public string SubmittedDate { get; }


    }
}
