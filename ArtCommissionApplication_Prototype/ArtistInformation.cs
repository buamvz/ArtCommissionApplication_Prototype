using System;
using System.Collections.Generic;
using System.Text;

namespace ArtCommissionApplication_Prototype
{
    public class ArtistInformation
    {
        public int ArtistId { get; set; }

        // profile info
        public string ArtistEmail { get; set; } = string.Empty;

        public string ArtistBio { get; set; } = string.Empty;

        // terms of service
        public string TosExpectations { get; set; } = string.Empty;

        public string TosWillDraw { get; set; } = string.Empty;

        public string TosWontDraw { get; set; } = string.Empty;
    }
}
