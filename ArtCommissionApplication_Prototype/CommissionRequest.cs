using System;
using System.Collections.Generic;
using System.Text;

namespace ArtCommissionApplication_Prototype
{
    public class CommissionRequest
    {
        //having majority as get without set so that the program cannot change as theyre set in the constructor
        public string Id { get; }
        public string ClientName { get; }
        public string ClientEmail { get; }
        public string CommissionType { get; }
        public string Description { get; }
        //decimal for estimated price as ita representing money $$$
        public decimal EstimatedPrice { get; }
        //private set for commision status will be used to update the status of the commission request
        //cant alow invaild transitions in status
        public CommissionStatus Status { get; private set; }
        public DateTime SubmittedDate { get; }

        public CommissionRequest(string id, string clientName, string clientEmail, string commissionType, string description, decimal estimatedPrice)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Commission ID is required");

            if (string.IsNullOrWhiteSpace(clientName))
                throw new ArgumentException("Clients name is required");

            if (string.IsNullOrWhiteSpace(clientEmail))
                throw new ArgumentException("Clients email is required");

            if (string.IsNullOrWhiteSpace(commissionType))
                throw new ArgumentException("Commission type is required");

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("A description for the commission is required");

            if (estimatedPrice < 0)
                throw new ArgumentException("Estimated price cannot be negative");

            //initialising properties with values needed
            Id = id;
            ClientName = clientName;
            ClientEmail = clientEmail;

            CommissionType = commissionType;
            Description = description;
            EstimatedPrice = estimatedPrice;

            Status = CommissionStatus.Pending;
            SubmittedDate = DateTime.Now;
        }
    }
}
