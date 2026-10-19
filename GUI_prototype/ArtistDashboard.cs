using ArtCommissionApplication_Prototype;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
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

            LoadQueueDatabaseData();
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
            if (listPanel == artistAcceptedCommissionsList || listPanel == artistCompletedCommissionsList)
            {
                statusChanger.Items.Add("InProgress");
                statusChanger.Items.Add("Completed");
            }
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

            // sienna - simplfication plus notification system
            var newStatus = (CommissionStatus)Enum.Parse(typeof(CommissionStatus), combo.SelectedItem.ToString());
            req.SetStatus(newStatus);

            CommissionRepository.UpdateStatus(req.Id, newStatus);

            NotificationRepository.AddNotification(req.Client.ClientName, $"Your commission #{req.Id} status changed to {newStatus}");
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

        private void LoadRejectedCommissionRequests()
        {
            try
            {
                CommissionArtistView.LoadAllFromDatabase();
                ClearIncomingCommissionsControls(artistRejectedCommissionsList);
                var rejected = CommissionArtistView.GetRejectedCommissions();
                foreach (var req in rejected)
                    AddCommissionToMyCommissions(req, artistRejectedCommissionsList);
            }
            catch
            {
                // ignore for prototype
            }
        }

        private void LoadCompletedCommissionRequests()
        {
            try
            {
                CommissionArtistView.LoadAllFromDatabase();
                ClearIncomingCommissionsControls(artistCompletedCommissionsList);
                var completed = CommissionArtistView.GetCompletedCommissions();
                foreach (var req in completed)
                    AddCommissionToMyCommissions(req, artistCompletedCommissionsList);
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

        private void reloadRejectedCommsButton_Click(object sender, EventArgs e)
        {
            LoadRejectedCommissionRequests();
        }
        private void reloadCompletedCommsButton_Click(object sender, EventArgs e)
        {
            LoadCompletedCommissionRequests();
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

        public void ArtistCommissionsDashboardTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ArtistCommissionsDashboardTabs.SelectedIndex;
            TabPage currentTab = ArtistCommissionsDashboardTabs.SelectedTab;

            if (currentTab == incomingCommissions)
            {
                LoadPendingCommissionRequests();
            }
            else if (currentTab == acceptedCommissions)
            {
                LoadAcceptedCommissionRequests();
            }
            else if (currentTab == artistQueue)
            {
                LoadQueueDatabaseData();
            }
            else if (currentTab == rejectedCommissions)
            {
                LoadRejectedCommissionRequests();
            }
            else if (currentTab == completedCommissions)
            {
                LoadCompletedCommissionRequests();
            }
        }


        // == update artist profile info ===
        // sienna - artist information and artist user to be used between all artist info
        private ArtistInformation artistInformation;
        private User artistUser;

        private void GetRepositoryInfo()
        {
            artistInformation = ArtistRepository.GetArtistProfile();
            artistUser = UserRepository.GetArtistUser();

            if (artistUser == null) return;
            if (artistInformation == null) return;
        }

        private void LoadArtistProfile()
        {
            GetRepositoryInfo();

            usernameTextBox.Text = artistUser.Username;
            // sienna - quick checks if artist information is empty to have default text
            if (string.IsNullOrWhiteSpace(artistInformation.ArtistEmail)) emailTextBox.Text = "Enter a valid email for clients to contact you at.";
            else emailTextBox.Text = artistInformation.ArtistEmail;
            if (string.IsNullOrWhiteSpace(artistInformation.ArtistBio)) bioTextBox.Text = "Enter a short bio for clients to get to know you. Include your prefered name, pronouns, interensts, etc";
            else bioTextBox.Text = artistInformation.ArtistBio;
        }

        private void SaveArtistProfileChanges() // sienna - saves new changes
        {
            if (usernameTextBox != null)
                UserRepository.UpdateUsername(artistUser.Username, usernameTextBox.Text);

            if (emailTextBox != null)
            {
                var m = new MailAddress(emailTextBox.Text);
                if (m.Address != emailTextBox.Text)
                {
                    errorProvider1.SetError(emailTextBox, "Enter a valid email address.");
                }
                else
                    artistInformation.ArtistEmail = emailTextBox.Text;
            }


            if (bioTextBox != null)
                artistInformation.ArtistBio = bioTextBox.Text;

            ArtistRepository.UpdateArtistProfile(artistInformation);
        }
        private void artistProfileTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check which tab is currently selected
            int index = artistProfileTabs.SelectedIndex;
            TabPage currentTab = artistProfileTabs.SelectedTab;

            if (currentTab == artistProfile)
            {
                LoadArtistProfile();
            }
            else if (currentTab == tosEditor)
            {
                LoadTosInformation();
            }
        }
        private void artistTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = artistTabs.SelectedIndex;
            TabPage currentTab = artistTabs.SelectedTab;

            if (currentTab == artistInformationTab)
            {
                LoadArtistProfile();
            }
        }
        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveArtistProfileChanges();

                MessageBox.Show("Profile saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // == update artist Terms of Service info ===
        private void LoadTosInformation()
        {
            GetRepositoryInfo();

            if (string.IsNullOrWhiteSpace(artistInformation.TosExpectations)) termsTextBox.Text = "You're general terms of service should include things like refund policies, use-rights, and other client expectations.";
            else termsTextBox.Text = artistInformation.TosExpectations;
            if (string.IsNullOrWhiteSpace(artistInformation.TosWillDraw)) willDrawTextBox.Text = "Enter concepts you're willing to draw. E.g. Profile pictures, Detailed backgrounds, Animals, etc.";
            else willDrawTextBox.Text = artistInformation.TosWillDraw;
            if (string.IsNullOrWhiteSpace(artistInformation.TosWontDraw)) wontDrawTextBox.Text = "Enter concepts you're NOT willing to draw. E.g. Hate speech, Gore, NSFW, etc.";
            else wontDrawTextBox.Text = artistInformation.TosWontDraw;
        }

        private void SaveTosInformationChanges()
        {
            if (termsTextBox != null)
                artistInformation.TosExpectations = termsTextBox.Text;

            if (willDrawTextBox != null)
                artistInformation.TosWillDraw = willDrawTextBox.Text;

            if (bioTextBox != null)
                artistInformation.TosWontDraw = wontDrawTextBox.Text;

            ArtistRepository.UpdateArtistProfile(artistInformation);
        }

        private void saveChangesTosButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveTosInformationChanges();

                MessageBox.Show("Profile saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editPfpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature not yet implemented.", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
