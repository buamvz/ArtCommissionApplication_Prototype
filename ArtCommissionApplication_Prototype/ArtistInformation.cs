using System;
using System.Collections.Generic;
using System.Text;

namespace ArtCommissionApplication_Prototype
{
    // sienna - small glass to hold artworks
    public class SampleArtwork
    {
        public string artworkName;
    }

    public class ArtistInformation
    {
        // sienna - making artist so information can be edited by the artist and saved to the client side form

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
