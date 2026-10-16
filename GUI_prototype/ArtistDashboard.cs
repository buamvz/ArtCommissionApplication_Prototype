using ArtCommissionApplication_Prototype;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static ArtCommissionApplication_Prototype.CommissionInformation;

namespace GUI_prototype
{
    public partial class ArtistDashboard : Form
    {
        public ArtistDashboard()
        {
            InitializeComponent();
        }


        // === Incoming Commission Requests - Accept and Deny  & Accepted commission request === 
        // note - perhaps change from a combo box on the incoming side to buttons for accept or deny that give confirmation boxes?

        // sienna - heavily taken from client commissions function 


        // helper to clear existing commission controls from the incoming list area
        private void ClearIncomingCommissionsControls(FlowLayoutPanel listPanel)
        {
            for (int i = listPanel.Controls.Count - 1; i >= 0; i--)
            {
                var c = listPanel.Controls[i];
                if (c == incomingCommissionsLabel || c == reloadCommRequestsButton || c == acceptedCommissionsLabel || c == reloadAcceptedCommsButton)
                    continue;

                listPanel.Controls.RemoveAt(i);
                c.Dispose();
            }
        }

        // sienna - helper to add a commission request to the incoming commissions list
        public void AddCommissionToMyCommissions(ArtCommissionApplication_Prototype.CommissionRequest req, FlowLayoutPanel listPanel)
        {
            if (req == null) return;

            // sienna - creates containter and objects inside - right and left panels
            var sc = new SplitContainer();
            sc.Orientation = Orientation.Vertical;
            sc.Size = new Size(780, 130);
            sc.SplitterDistance = 359;
            sc.Panel1.BackColor = Color.Gainsboro;
            sc.Panel2.BackColor = Color.WhiteSmoke;

            var statusLabel = new Label();
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            statusLabel.Location = new Point(5, 6);
            statusLabel.Text = "Status: " + req.Status.ToString();

            var statusChanger = new ComboBox();
            statusChanger.AutoSize = true;
            statusChanger.DropDownStyle = ComboBoxStyle.DropDownList;
            statusChanger.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            statusChanger.Location = new Point(200, 3);
            statusChanger.Items.Add("Pending");
            statusChanger.Items.Add("Rejected");
            statusChanger.Items.Add("Accepted");
            statusChanger.SelectedItem = req.Status.ToString();
            statusChanger.Tag = req;
            statusChanger.SelectedIndexChanged += StatusChanger_SelectedIndexChanged;


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
            sc.Panel1.Controls.Add(statusChanger);
            sc.Panel1.Controls.Add(detailsLabel);
            sc.Panel1.AutoScroll = true;

            // Optionally put a short summary in panel2
            var rightSummary = new Label();
            rightSummary.AutoSize = true;
            rightSummary.Font = new Font("Segoe UI", 10F);
            rightSummary.Location = new Point(5, 6);
            rightSummary.Text = $"ID: {req.Id}";
            sc.Panel2.Controls.Add(rightSummary);

            listPanel.Controls.Add(sc);
        }

        private void StatusChanger_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            CommissionRequest req = (CommissionRequest)combo.Tag;

            if (req == null) throw new ArgumentException("Commission request is null, no status to change."); ;

            switch (combo.SelectedItem.ToString())
            {
                case "Pending":
                    req.SetStatus(CommissionStatus.Pending);
                    CommissionRepository.UpdateStatus(req.Id, CommissionStatus.Pending);
                    break;

                case "Rejected":
                    req.SetStatus(CommissionStatus.Rejected);
                    CommissionRepository.UpdateStatus(req.Id, CommissionStatus.Rejected);
                    break;

                case "Accepted":
                    req.SetStatus(CommissionStatus.Accepted);
                    CommissionRepository.UpdateStatus(req.Id, CommissionStatus.Accepted);
                    break;
            }
        }

        private void LoadPendingCommissionRequests()
        {
            // Refresh the in-memory artist view and show pending requests
            try
            {
                CommissionArtistView.LoadAllFromDatabase();
                ClearIncomingCommissionsControls(artistPendingCommissionsList);
                var pending = CommissionArtistView.GetPendingCommissions();
                foreach (var req in pending)
                    AddCommissionToMyCommissions(req, artistPendingCommissionsList);
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
                ClearIncomingCommissionsControls(artistAcceptedCommissionsList);
                var accepted = CommissionArtistView.GetAcceptedCommissions();
                foreach (var req in accepted)
                    AddCommissionToMyCommissions(req, artistAcceptedCommissionsList);
            }
            catch
            {
                // ignore for prototype
            }
        }

        private void reloadCommRequestsButton_Click(object sender, EventArgs e)
        {
            LoadPendingCommissionRequests();
        }

        private void reloadAcceptedCommsButton_Click(object sender, EventArgs e)
        {
            LoadAcceptedCommissionRequests();
        }

        // === Artist side private queue - displays all information === 

        // load queue from data base into visuals
        private readonly string connectionString = $"Data Source={DatabaseConfig.DatabasePath}";
        private DataTable dataTable;

        private void LoadQueueDatabaseData()
        {
            try
            {
                using var connection = new SqliteConnection(connectionString);
                connection.Open();

                using var cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT Id, ClientName, ClientEmail, CropType, NumberOfCharacters, HasBackground, EstimatedPrice, NeedByDate, Status FROM Commissions;";

                using var reader = cmd.ExecuteReader();

                dataTable = new DataTable();
                dataTable.Load(reader);

                artistViewQueueGrid.DataSource = dataTable;

                artistViewQueueGrid.Columns["EstimatedPrice"].DefaultCellStyle.Format = "C";
            }
            catch (Exception ex)
            {
                // error box for failed load
                MessageBox.Show($"Failed to load queue from database: {ex.Message}", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ArtistViewQueueGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string columnName =
                artistViewQueueGrid.Columns[e.ColumnIndex].Name;

            if (columnName == "Status" && e.Value != null && e.Value != DBNull.Value)
            {
                e.Value = ((CommissionStatus)Convert.ToInt32(e.Value)).ToString();
                e.FormattingApplied = true;
            }

            if (columnName == "HasBackground" && e.Value != null && e.Value != DBNull.Value)
            {
                e.Value = Convert.ToInt32(e.Value) == 1 ? "Yes" : "No";
                e.FormattingApplied = true;
            }

            if (columnName == "NeedByDate" && e.Value != null && e.Value != DBNull.Value)
            {
                if (DateTime.TryParse(e.Value.ToString(), out DateTime dt))
                {
                    e.Value = dt.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }
        }

        private void ReloadQueue()
        {
            LoadQueueDatabaseData();
        }

        private void reloadQueueButton_Click(object sender, EventArgs e)
        {
            ReloadQueue();
        }
    }
}
