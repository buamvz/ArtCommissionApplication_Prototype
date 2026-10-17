using System;
using System.Collections.Generic;
using System.Text;

namespace ArtCommissionApplication_Prototype
{
    public class ArtistInformation
    {
        public int ArtistId { get; set; }

        // artist info
        public string artistName { get; set; }
        public string artistEmail { get; set; }

        public string artistBio;

        // tos stuff
        public string tosExpectations;
        public string tosWillDraw;
        public string tosWontDraw;

    }
}
