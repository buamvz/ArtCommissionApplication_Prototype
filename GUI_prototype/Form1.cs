using Microsoft.Data.Sqlite;
using System.Data;
using ArtCommissionApplication_Prototype;
using System.Drawing;
using System.Linq;
using System;


namespace GUI_prototype
{
    public partial class Form1 : Form
    {
        // UI elements for simple role switching in the prototype

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (CommissionRepository.CommissionTableExists())
                LoadQueueDatabaseData();
        }
        private void RequestComm_Click(object sender, EventArgs e)
        {
            Form2 newWindow = new Form2();

            newWindow.Show();
            // this.Hide();
        }

        // === Public Queue ===
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
                cmd.CommandText = "SELECT Id, ClientName, CropType, NumberOfCharacters, HasBackground, Status FROM Commissions;"; // sienna - loads only what we want public

                using var reader = cmd.ExecuteReader();

                dataTable = new DataTable();
                dataTable.Load(reader);

                publicQueueGrid.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // error box for failed load
                MessageBox.Show($"Failed to load queue from database: {ex.Message}", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void PublicQueueGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string columnName =
                publicQueueGrid.Columns[e.ColumnIndex].Name;

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
        }


        private void ReloadQueue()
        {
            LoadQueueDatabaseData();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            ReloadQueue();
        }

        // === Client My Commission info ===

        // Load commissions for the currently active user into the "My Commissions" view.
        private void LoadMyCommissions()
        {
            if (SessionManager.CurrentActiveUser == null)
                return;

            // Keep the header label (labelMyComms) and the explicit reload button (reloadCommissionsButton)
            for (int i = userMyCommissionsList.Controls.Count - 1; i >= 0; i--)
            {
                var c = userMyCommissionsList.Controls[i];
                if (c == labelMyComms || c == reloadCommissionsButton)
                    continue;

                userMyCommissionsList.Controls.RemoveAt(i);
                c.Dispose();
            }

            try
            {
                var all = CommissionRepository.GetAll();
                var mine = all.Where(r => r.Client.ClientName == SessionManager.CurrentActiveUser.Username);
                foreach (var req in mine)
                {
                    AddCommissionToMyCommissions(req);
                }
            }
            catch
            {
                // ignore for prototype
            }
        }

        // sienna - public helper so other forms can ask to show a new commission in the "My Commissions" tab
        public void AddCommissionToMyCommissions(ArtCommissionApplication_Prototype.CommissionRequest req)
        {
            if (req == null) return;

            // sienna - creates containter and objects inside - right and left panels
            var sc = new SplitContainer();
            sc.Orientation = Orientation.Vertical; // side-by-side panels like the designer template
            sc.Size = new Size(786, 130);
            sc.SplitterDistance = 359; // match designer template distance (approx)
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

            userMyCommissionsList.Controls.Add(sc);
        }

        private void tabMyCommissions_Client_Click(object sender, EventArgs e)
        {
            LoadMyCommissions();
        }

        private void reloadCommissionsButton_Click_1(object sender, EventArgs e)
        {
            LoadMyCommissions();
        }

        // === Client Profile Info ===
        private void clientProfileTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check which tab is currently selected
            int index = clientProfileTabs.SelectedIndex;
            TabPage currentTab = clientProfileTabs.SelectedTab;

            if (currentTab == userProfile)
            {
                updateProfile();
            }
        }
        private void updateProfile()
        {
            List<string> userEmails = new List<string>();

            var all = CommissionRepository.GetAll();
            var mine = all.Where(r => r.Client.ClientName == SessionManager.CurrentActiveUser.Username);
            foreach (var req in mine)
            {
                userEmails.Add(req.Client.ClientEmail);
            }

            if (SessionManager.CurrentActiveUser.Role == SystemRole.Client)
            {
                clientProfileLabel.Text =
                    "Username: " + SessionManager.CurrentActiveUser.Username + "\n" +
                    "Password: " + "***" + "\n \n" +
                    "Associated Emails: \n" + string.Join("\n", userEmails) + "\n";
            }
        }

        // sienna - update artist profile information
        private ArtistInformation artistInformation;
        private User artistUser;
        private void LoadArtistInformation()
        {
            artistInformation = ArtistRepository.GetArtistProfile();
            artistUser = UserRepository.GetArtistUser();

            if (artistUser == null || artistInformation == null) return;

            labelArtistName.Text = artistUser.Username;

            labelArtistEmail.Text = "Email: " + artistInformation.ArtistEmail;

            labelArtistBio.Text = artistInformation.ArtistBio;
        }
        private void LoadArtistTos()
        {
            artistInformation = ArtistRepository.GetArtistProfile();
            if (artistInformation == null) return;

            labelTerms.Text = artistInformation.TosExpectations;

            labelWillDraw.Text = "Will Draw \n " + artistInformation.TosWillDraw;

            labelWontDraw.Text = "Won't Draw \n" + artistInformation.TosWontDraw;
        }


        private void tabAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check which tab is currently selected
            int index = tabAll.SelectedIndex;
            TabPage currentTab = tabAll.SelectedTab;

            if (currentTab == tabInformation)
            {
                LoadArtistInformation();
            }
            else if (currentTab == tabTOS)
            {
                LoadArtistTos();
            }
        }
    }
}
