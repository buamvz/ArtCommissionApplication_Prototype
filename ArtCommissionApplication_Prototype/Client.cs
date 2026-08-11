using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ArtCommissionApplication_Prototype
{
    public class Client
    {
        public string Id { get; }
        public string ClientName { get; }
        public string ClientEmail { get; }


        public Client(string clientName, string email) 
        {
            // sienna - dont need id?
            // if (string.IsNullOrWhiteSpace(id))
            //    throw new ArgumentException("Commission ID is required.");

            if (string.IsNullOrWhiteSpace(clientName))
                throw new ArgumentException("Clients name is required.");

            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Clients email is required.");


            // Id = id;
            ClientName = clientName;
            ClientEmail = email;
        }
        
    }
}
