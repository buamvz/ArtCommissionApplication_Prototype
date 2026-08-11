using System;
using System.Collections.Generic;
using System.Text;

namespace ArtCommissionApplication_Prototype
{
    public class CommissionType
    {
        public CommissionCrop CropType;
        public enum CommissionCrop
        {
            Headshot,
            Halfbody,
            Fullbody,
        }

        public bool HasBackground { get; }
        public int EstimatedCost { get; private set;  }

        public CommissionType(CommissionCrop crommissionCrop, bool hasBackground) 
        {
            // add null checks

            CropType = crommissionCrop;
            HasBackground = hasBackground;
            EstimatedCost = EstimateCost();
        }

        public int EstimateCost()
        {
            int CalculateEstimatedCost = 0;

            switch(CropType)
            { 
                case CommissionCrop.Headshot:
                    CalculateEstimatedCost += 30; 
                    break;
                case CommissionCrop.Halfbody:
                    CalculateEstimatedCost += 50; 
                    break;
                case CommissionCrop.Fullbody:
                    CalculateEstimatedCost += 60;
                    break;
            }

            if (HasBackground)
                CalculateEstimatedCost += 15;

            return CalculateEstimatedCost;
        }
    }
}
