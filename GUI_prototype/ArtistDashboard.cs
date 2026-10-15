using ArtCommissionApplication_Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_prototype
{
    public partial class ArtistDashboard : Form
    {
        public ArtistDashboard()
        {
            InitializeComponent();
        }
        // === Incoming Commission Requests - Accept and Deny ===
        // sienna - heavily taken from client commissions function 
        private void LoadPendingCommissionRequests()
        {
            // Refresh the in-memory artist view and show pending requests
            try
            {
                CommissionArtistView.LoadAllFromDatabase();
                ClearIncomingCommissionsControls();
                var pending = CommissionArtistView.GetPendingCommissions();
                foreach (var req in pending)
                    AddCommissionToMyCommissions(req);
            }
            catch
            {
                // ignore for prototype
            }
        }
        private void LoadAcceptedCommissionRequests()
        {
            try
            {
                CommissionArtistView.LoadAllFromDatabase();
                ClearIncomingCommissionsControls();
                var accepted = CommissionArtistView.GetAcceptedCommissions();
                foreach (var req in accepted)
                    AddCommissionToMyCommissions(req);
            }
            catch
            {
                // ignore for prototype
            }
        }

        // helper to clear existing commission controls from the incoming list area
        private void ClearIncomingCommissionsControls()
        {
            for (int i = artistPendingCommissionsList.Controls.Count - 1; i >= 0; i--)
            {
                var c = artistPendingCommissionsList.Controls[i];
                if (c == incomingCommissionsLabel || c == reloadCommRequestsButton || c == acceptedCommissionsLabel || c == reloadAcceptedCommsButton)
                    continue;

                artistPendingCommissionsList.Controls.RemoveAt(i);
                c.Dispose();
            }
        }

        // sienna - helper to add a commission request to the incoming commissions list
        public void AddCommissionToMyCommissions(ArtCommissionApplication_Prototype.CommissionRequest req)
        {
            if (req == null) return;

            // sienna - creates containter and objects inside - right and left panels
            var sc = new SplitContainer();
            sc.Orientation = Orientation.Vertical;
            sc.Size = new Size(786, 130);
            sc.SplitterDistance = 359;
            sc.Panel1.BackColor = Color.Gainsboro;
            sc.Panel2.BackColor = Color.WhiteSmoke;

            var statusLabel = new Label();
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            statusLabel.Location = new Point(5, 6);
            statusLabel.Text = "Status: " + req.Status.ToString();

            var detailsLabel = new Label();
            detailsLabel.AutoSize = true;
            detailsLabel.Font = new Font("Segoe UI", 10F);
            detailsLabel.Location = new Point(5, 30);
            detailsLabel.MaximumSize = new Size(340, 0);
            var ci = req.CommissionType;
            detailsLabel.Text =
                $"Name: {req.Client.ClientName}\n" +
                $"Email: {req.Client.ClientEmail}\n" +
                "Commission Details:\n" +
                $"Crop: {ci.CropType}\n" +
                $"Number of Characters: {ci.NumberOFCharacters}\n" +
                $"Has Background: {ci.HasBackground}\n" +
                $"Description: {ci.Description}\n\n" +
                $"Estimated Price: {ci.EstimatedPrice:C}";

            sc.Panel1.Controls.Add(statusLabel);
            sc.Panel1.Controls.Add(detailsLabel);
            sc.Panel1.AutoScroll = true;

            // Optionally put a short summary in panel2
            var rightSummary = new Label();
            rightSummary.AutoSize = true;
            rightSummary.Font = new Font("Segoe UI", 10F);
            rightSummary.Location = new Point(5, 6);
            rightSummary.Text = $"Submitted: {req.SubmittedDate:g}\nID: {req.Id}";
            sc.Panel2.Controls.Add(rightSummary);

            artistPendingCommissionsList.Controls.Add(sc);
        }

        private void reloadCommRequestsButton_Click(object sender, EventArgs e)
        {
            LoadPendingCommissionRequests();
        }

        private void reloadAcceptedCommsButton_Click(object sender, EventArgs e)
        {
            LoadAcceptedCommissionRequests();
        }
    }
}
