using System;
using System.Collections.Generic;
using System.Text;

namespace ArtCommissionApplication_Prototype
{
    public class RequestResult
    {
        public bool Accepted { get; }
        public string Message { get; }

        public RequestResult(bool accepted, string message) 
        {
            Accepted = accepted;
            Message = message;
        }
    }
}
