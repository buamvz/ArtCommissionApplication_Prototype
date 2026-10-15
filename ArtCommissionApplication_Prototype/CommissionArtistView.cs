using System;
using System.Collections.Generic;
using System.Text;

namespace ArtCommissionApplication_Prototype
{
    // Minimal static helper used by the GUI to present an artist's view of commissions.
    // Keeps an in-memory cache and exposes simple query helpers so form code doesn't need
    // to talk to the repository directly.
    public static class CommissionArtistView
    {
        private static readonly List<CommissionRequest> commissions = new List<CommissionRequest>();

        public static void AddCommission(CommissionRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            if (!commissions.Contains(request)) commissions.Add(request);
        }

        // Load or refresh the in-memory cache from the repository
        public static void LoadAllFromDatabase()
        {
            commissions.Clear();
            List<CommissionRequest> databaseCommissions = CommissionRepository.GetAll();
            if (databaseCommissions == null) return;
            foreach (CommissionRequest commission in databaseCommissions)
                AddCommission(commission);
        }

        // Query helpers for the UI
        public static List<CommissionRequest> GetPendingCommissions()
        {
            return commissions.FindAll(c => c.Status == CommissionStatus.Pending);
        }

        public static List<CommissionRequest> GetAcceptedCommissions()
        {
            return commissions.FindAll(c => c.Status == CommissionStatus.Accepted);
        }
    }
}
