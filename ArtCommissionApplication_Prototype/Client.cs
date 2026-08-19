using System;
using System.Collections.Generic;
using System.Numerics;
using System.Net.Mail; //Brooke
using System.Text;

namespace ArtCommissionApplication_Prototype
{
    public class Client
    {
        // sienna - change so that the program automatically gives client an ID
        // public string Id { get; }
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

            //Brooke - currently email only checks if its null
            //random things that aren't an email can pass, this would be a buisness issue for artist contacting the client as the email would be invaild
            try
            {
                var mailAddress = new MailAddress(email);

                if (mailAddress.Address != email)
                    throw new ArgumentException("Clients email must be a valid email address.");
            }
            catch
            {
                throw new ArgumentException("Clients email must be a valid email address.");
            }


            // Id = id;
            ClientName = clientName;
            ClientEmail = email;
        }
        
    }
}
