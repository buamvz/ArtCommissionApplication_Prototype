using System;
using System.Collections.Generic;
using System.Text;

namespace ArtCommissionApplication_Prototype
{
    public class AdminDashboardStatistics
    {
        public int TotalCommissions { get; set; }
        public int ActiveCommissions { get; set; }
        public int CompletedCommissions { get; set; }
        public int OverdueCommissions { get; set; }
    }

    // Small service to calculate admin dashboard statistics from the repository.
    public static class AdminDashboardStatisticsService
    {
        public static AdminDashboardStatistics Calculate()
        {
            var all = CommissionRepository.GetAll();

            var stats = new AdminDashboardStatistics();
            stats.TotalCommissions = all.Count;
            stats.ActiveCommissions = 0;
            stats.CompletedCommissions = 0;
            stats.OverdueCommissions = 0;

            foreach (var c in all)
            {
                if (c.Status == CommissionStatus.Accepted || c.Status == CommissionStatus.InProgress)
                    stats.ActiveCommissions++;

                if (c.Status == CommissionStatus.Completed)
                    stats.CompletedCommissions++;

                if (c.CommissionType.NeedByDate.HasValue)
                {
                    var due = c.CommissionType.NeedByDate.Value.Date;
                    if (due < DateTime.Today && c.Status != CommissionStatus.Completed && c.Status != CommissionStatus.Rejected)
                        stats.OverdueCommissions++;
                }
            }

            return stats;
        }
    }
}
