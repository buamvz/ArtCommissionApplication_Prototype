using System;
using System.Collections.Generic;
using System.Linq;

namespace ArtCommissionApplication_Prototype
{
    public class CommissionTypeStatistic
    {
        public CommissionInformation.CharacterCrop CropType { get; set; }
        public int Count { get; set; }
        public double PercentageOfTotal { get; set; }
        public decimal BasePrice { get; set; }
        public decimal TotalEstimatedPrice { get; set; }
    }

    public class CommissionTypeStatisticsResult
    {
        public int TotalCount { get; set; }
        public List<CommissionTypeStatistic> Items { get; set; } = new();
    }

    public class YearlyVolumeSeries
    {
        public int Year { get; set; }
        // 12 months, index 0 = January
        public int[] MonthlyCounts { get; set; } = new int[12];
    }

    public class YearlyVolumeResult
    {
        public List<YearlyVolumeSeries> Series { get; set; } = new();
    }

    public static class QualityStatisticsService
    {
        // Calculate commission type statistics (counts, percentages, totals) using CommissionRepository.GetAll()
        public static CommissionTypeStatisticsResult CalculateTypeStatistics()
        {
            var all = CommissionRepository.GetAll() ?? new List<CommissionRequest>();
            var result = new CommissionTypeStatisticsResult();
            result.TotalCount = all.Count;

            var crops = Enum.GetValues(typeof(CommissionInformation.CharacterCrop)).Cast<CommissionInformation.CharacterCrop>();

            foreach (var crop in crops)
            {
                var items = all.Where(r => r.CommissionType != null && r.CommissionType.CropType == crop).ToList();
                var stat = new CommissionTypeStatistic
                {
                    CropType = crop,
                    Count = items.Count,
                    TotalEstimatedPrice = items.Sum(i => i.CommissionType?.EstimatedPrice ?? 0m),
                    BasePrice = CommissionInformation.EstimatePriceFor(crop, false, 1)
                };

                stat.PercentageOfTotal = result.TotalCount == 0 ? 0.0 : (double)stat.Count / result.TotalCount * 100.0;

                result.Items.Add(stat);
            }

            return result;
        }

        // Calculate yearly volume grouped by SubmittedDate year and month. Each year will have 12 months (Jan..Dec)
        public static YearlyVolumeResult CalculateYearlyVolume()
        {
            var all = CommissionRepository.GetAll() ?? new List<CommissionRequest>();
            var result = new YearlyVolumeResult();

            var grouped = all.GroupBy(r => r.SubmittedDate.Year).OrderBy(g => g.Key);

            foreach (var g in grouped)
            {
                var series = new YearlyVolumeSeries { Year = g.Key };
                foreach (var req in g)
                {
                    var monthIndex = Math.Max(1, req.SubmittedDate.Month) - 1;
                    series.MonthlyCounts[monthIndex]++;
                }

                result.Series.Add(series);
            }

            return result;
        }
    }
}
