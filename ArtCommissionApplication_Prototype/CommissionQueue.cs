using System;
using System.Collections.Generic;
using System.Text;

namespace ArtCommissionApplication_Prototype
{
    public class CommissionQueue
    {
        //internal storage list for the commission request from customers
        private readonly List<CommissionRequest> commissions = new List<CommissionRequest>();

        public IReadOnlyList<CommissionRequest> Commissions => commissions; //public read only access to commission list

        public void AddCommission(CommissionRequest request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            if (!commissions.Contains(request))
                commissions.Add(request);
        }

        //method finding a commission base 1 position in the queue line
        public int GetQueuePosition(CommissionRequest request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            int position = commissions.IndexOf(request);

            //0 if nothing in queue
            if (position == -1)
                return 0;

            return position + 1;
        }

        //total of commissions in the queue
        public int Count => commissions.Count;



        public void LoadFromDatabase()
        {
            commissions.Clear();

            List<CommissionRequest> databaseCommissions = CommissionRepository.GetAll();

            foreach (CommissionRequest commission in databaseCommissions)
            {
                AddCommission(commission);
            }
        }

    }





}
