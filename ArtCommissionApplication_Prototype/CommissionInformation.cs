using System;
using System.Collections.Generic;
using System.Text;

namespace ArtCommissionApplication_Prototype
{
    public class CommissionInformation
    {
        public CharacterCrop CropType;
        public enum CharacterCrop
        {
            Headshot,
            Halfbody,
            Fullbody,
        }

        // ADD NUMBER OF CHARACTERS

        public bool HasBackground { get; }
        public string Description { get; }
        public decimal EstimatedPrice { get; private set; }
        public DateTime? NeedByDate { get; }

        public CommissionInformation(CharacterCrop characterCrop, bool hasBackground, string description, DateTime? needByDate) 
        {
            // check given character crop type is valid
            if (!Enum.IsDefined(typeof(CharacterCrop), characterCrop))
                throw new ArgumentException($"Invalid commission character crop type: {characterCrop}, please select a valid character crop type.");

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("A description for the commission is required."); 
                // maybe do an if-contains-words to eliminate some things that go against TOS ?

            // require 1 week notice on commission requests
            if (needByDate <= DateTime.Today.AddDays(7))
                throw new ArgumentException("One week notice is required at minimum for a commission. Please select a later date.");

            if (needByDate == null)
                NeedByDate = null;

            CropType = characterCrop;
            HasBackground = hasBackground;
            Description = description;

            EstimatedPrice = EstimatePrice();

            NeedByDate = needByDate;
        }

        public decimal EstimatePrice()
        {
            decimal CalculateEstimatedPrice = 0;

            switch(CropType)
            { 
                case CharacterCrop.Headshot:
                    CalculateEstimatedPrice += 30; 
                    break;
                case CharacterCrop.Halfbody:
                    CalculateEstimatedPrice += 50; 
                    break;
                case CharacterCrop.Fullbody:
                    CalculateEstimatedPrice += 60;
                    break;
            }

            if (HasBackground)
                CalculateEstimatedPrice += 15;


            if (CalculateEstimatedPrice < 0)
                throw new ArgumentException("Estimated price cannot be negative.");

            return CalculateEstimatedPrice;
        }
    }
}
