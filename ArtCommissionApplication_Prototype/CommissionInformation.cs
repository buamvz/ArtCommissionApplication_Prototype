using System;
using System.Collections.Generic;
using System.Text;

namespace ArtCommissionApplication_Prototype
{
    public class CommissionInformation
    {
        public CharacterCrop CropType { get; }
        public enum CharacterCrop
        {
            Headshot,
            Halfbody,
            Fullbody,
        }

        public int NumberOFCharacters { get; }
        public bool HasBackground { get; }
        public string Description { get; }
        public decimal EstimatedPrice { get; private set; }
        public DateTime? NeedByDate { get; }

        public CommissionInformation(CharacterCrop characterCrop, int numberOfCharacters, bool hasBackground, string description, DateTime? needByDate) 
        {
            // check given character crop type is valid
            if (!Enum.IsDefined(typeof(CharacterCrop), characterCrop))
                throw new ArgumentException($"Invalid commission character crop type: {characterCrop}, please select a valid character crop type.");

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("A description for the commission is required.");
            // maybe do an if-contains-words to eliminate some things that go against TOS ?

            //Brooke - requested date cannot be in the past, this is a business rule defect
            //prevents invaild commission deadlines from entering the system
            //problem that needByDate is nullable(DateTime) and that null is allowed later
            //if (needByDate == null)
            //    NeedByDate = null;

            //Brooke - require 1 week notice on commission requests + now doesn't allow in the past
            //changed from <= to < as the rule is minium 7 days notice 
            //if the request is 7 days then <= 7 wont accept 7 days which would be a weeks notice
            //this helps prevent unrealistic deadlines and supports commission planning
            if (needByDate.HasValue && needByDate.Value.Date < DateTime.Today.AddDays(7))
                throw new ArgumentException("One week notice is required at minimum for a commission. Please select a later date.");

            // sienna - commission must contain between 1 and 5 characters inclusive
            if (numberOfCharacters < 1 || numberOfCharacters > 5)
                throw new ArgumentException("A commission must contain between 1 and 5 characters.");

            CropType = characterCrop;
            NumberOFCharacters = numberOfCharacters;
            HasBackground = hasBackground;
            Description = description;

            EstimatedPrice = EstimatePrice();

            NeedByDate = needByDate;
        }

        // Sienna - edited price estimate so it can be previewed without having all commission information completed
        // Recalculate the stored estimate from current instance info
        public void RecalculateEstimate()
        {
            EstimatedPrice = EstimatePriceFor(CropType, HasBackground, NumberOFCharacters);
        }

        // Instance method - delegates to the shared static implementation.
        public decimal EstimatePrice()
        {
            return EstimatePriceFor(CropType, HasBackground, NumberOFCharacters);
        }

        // Static helper to estimate price from the main pricing inputs (doesn't need date or description)
        // The number of characters is clamped to at least 1 (since thats all that's possible) to allow estimate without full validation
        public static decimal EstimatePriceFor(CharacterCrop crop, bool hasBackground, int numberOfCharacters = 1)
        {
            decimal basePrice = 0;

            switch (crop)
            {
                case CharacterCrop.Headshot:
                    basePrice += 30;
                    break;
                case CharacterCrop.Halfbody:
                    basePrice += 50;
                    break;
                case CharacterCrop.Fullbody:
                    basePrice += 60;
                    break;
            }

            if (hasBackground)
                basePrice += 15;

            if (numberOfCharacters < 1)
                numberOfCharacters = 1;

            // Scale price by number of characters.
            var calculated = basePrice * numberOfCharacters;

            if (calculated < 0)
                throw new ArgumentException("Estimated price cannot be negative.");

            return calculated;
        }
    }
}
