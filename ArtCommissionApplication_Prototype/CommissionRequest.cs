using System;
using System.Collections.Generic;
using System.Text;

namespace ArtCommissionApplication_Prototype
{
    public class CommissionRequest
    {
        //having majority as get without set so that the program cannot change as theyre set in the constructor

        // sienna - adding classes for client and commission type
        public Client Client { get;  }

        public CommissionType CommissionType { get; }
        // public string CommissionType { get; }
        public string Description { get; }


        //decimal for estimated price as ita representing money $$$
        public decimal EstimatedPrice { get; }
        //private set for commision status will be used to update the status of the commission request
        //cant alow invaild transitions in status
        public CommissionStatus Status { get; private set; }
        public DateTime SubmittedDate { get; }

        public CommissionRequest(Client client, CommissionType commissionType, string description, decimal estimatedPrice)
        {
            Client = client ?? throw new ArgumentNullException(nameof(client));
            CommissionType = commissionType ?? throw new ArgumentNullException(nameof(commissionType));

            //if (string.IsNullOrWhiteSpace(commissionType))
            //    throw new ArgumentException("Commission type is required.");

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("A description for the commission is required.");

            if (estimatedPrice < 0)
                throw new ArgumentException("Estimated price cannot be negative.");

            //initialising properties with values needed

            //Client = client;
            //CommissionType = commissionType;

            Description = description;
            EstimatedPrice = estimatedPrice;

            Status = CommissionStatus.Pending;
            SubmittedDate = DateTime.Now;
        }
    }
}
