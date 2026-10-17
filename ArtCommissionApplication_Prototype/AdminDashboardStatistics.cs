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

        // These lists allow the admin GUI to display the actual commissions.
        public List<CommissionRequest> ActiveCommissionRequests { get; set; } = new();
        public List<CommissionRequest> OverdueCommissionRequests { get; set; } = new();
        public List<CommissionRequest> CompletedCommissionRequests { get; set; } = new();
    }



    // Small service to calculate admin dashboard statistics from the repository.
    public static class AdminDashboardStatisticsService
    {
        public static AdminDashboardStatistics Calculate()
        {
            var all = CommissionRepository.GetAll();
            var stats = new AdminDashboardStatistics();

            stats.TotalCommissions = all.Count;

            foreach (var commission in all)
            {
                var status = commission.Status;
                var needByDate = commission.CommissionType.NeedByDate;

                bool isOverdue =
                    needByDate.HasValue &&
                    needByDate.Value.Date < DateTime.Today &&
                    status != CommissionStatus.Completed &&
                    status != CommissionStatus.Rejected;

                // Completed commissions always belong in Completed.
                if (status == CommissionStatus.Completed)
                {
                    stats.CompletedCommissionRequests.Add(commission);
                }
                // Overdue takes priority over Active.
                else if (isOverdue)
                {
                    stats.OverdueCommissionRequests.Add(commission);
                }
                else if (status == CommissionStatus.Accepted ||
                         status == CommissionStatus.InProgress)
                {
                    stats.ActiveCommissionRequests.Add(commission);
                }
            }

            stats.ActiveCommissions = stats.ActiveCommissionRequests.Count;
            stats.OverdueCommissions = stats.OverdueCommissionRequests.Count;
            stats.CompletedCommissions = stats.CompletedCommissionRequests.Count;

            return stats;
        }
    }
}
