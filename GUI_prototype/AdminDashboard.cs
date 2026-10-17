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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        // Test helper: allows unit tests to check policy without creating a form instance
        public static bool CanAccess() => SessionManager.IsAdmin();

        // Enforce policy as early as possible in the form lifecycle
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (!SessionManager.IsAdmin())
            {
                // Friendly denial message then close the form immediately.
                MessageBox.Show("Access denied. Admins only.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close(); // close before user can interact with controls
                return;
            }

            // Continue normal load for admins...
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }


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

                adminViewQueueGrid.DataSource = dataTable;

                adminViewQueueGrid.Columns["EstimatedPrice"].DefaultCellStyle.Format = "C";
            }
            catch (Exception ex)
            {
                // error box for failed load
                MessageBox.Show($"Failed to load queue from database: {ex.Message}", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminViewQueueGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string columnName =
                adminViewQueueGrid.Columns[e.ColumnIndex].Name;

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

        // Reload the Commission Overview sections
        private void reloadCommOverviewButton_Click(object sender, EventArgs e)
        {
            BuildCommissionOverview();
        }

        // Build the three admin-only commission overview sections: Active, Overdue, Completed
        private void BuildCommissionOverview()
        {
            // Use the statistics service to get classified lists
            AdminDashboardStatistics stats;
            try
            {
                stats = AdminDashboardStatisticsService.Calculate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load commissions: {ex.Message}", "Load error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Clear dynamic children from the parent flow panel but keep permanent controls (labels/buttons)
            for (int i = artistAdminViewCommissionsList.Controls.Count - 1; i >= 0; i--)
            {
                var c = artistAdminViewCommissionsList.Controls[i];
                artistAdminViewCommissionsList.Controls.RemoveAt(i);
                c.Dispose();
            }

            // Helper to create a section
            FlowLayoutPanel MakeSection(string heading, List<CommissionRequest> list)
            {
                var container = new FlowLayoutPanel();
                container.FlowDirection = FlowDirection.TopDown;
                container.AutoSize = true;
                container.WrapContents = false;
                container.Width = artistAdminViewCommissionsList.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 10;

                var header = new Label();
                header.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                header.BackColor = Color.FromArgb(224, 224, 224);
                header.AutoSize = false;
                header.Height = 30;
                header.Width = container.Width;
                header.TextAlign = ContentAlignment.MiddleLeft;
                header.Text = $"{heading} ({list?.Count ?? 0})";

                container.Controls.Add(header);

                var inner = new FlowLayoutPanel();
                inner.FlowDirection = FlowDirection.TopDown;
                inner.WrapContents = false;
                inner.AutoSize = true;
                inner.Width = container.Width;
                inner.BackColor = Color.WhiteSmoke;

                if (list == null || list.Count == 0)
                {
                    var empty = new Label();
                    empty.Font = new Font("Segoe UI", 9F);
                    empty.Text = heading.StartsWith("Active") ? "No active commissions." : heading.StartsWith("Overdue") ? "No overdue commissions." : "No completed commissions.";
                    empty.AutoSize = true;
                    inner.Controls.Add(empty);
                }
                else
                {
                    foreach (var req in list)
                        inner.Controls.Add(CreateAdminCommissionCard(req));
                }

                container.Controls.Add(inner);
                return container;
            }

            // Add sections in order: Active, Overdue, Completed
            artistAdminViewCommissionsList.Controls.Add(MakeSection("Active Commissions", stats.ActiveCommissionRequests));
            artistAdminViewCommissionsList.Controls.Add(MakeSection("Overdue Commissions", stats.OverdueCommissionRequests));
            artistAdminViewCommissionsList.Controls.Add(MakeSection("Completed Commissions", stats.CompletedCommissionRequests));
        }

        // Create a read-only admin commission card similar in layout to the artist SplitContainer card
        private Control CreateAdminCommissionCard(CommissionRequest req)
        {
            var sc = new SplitContainer();
            sc.Orientation = Orientation.Vertical;
            sc.Size = new Size(780, 110);
            sc.SplitterDistance = 520;
            sc.Panel1.BackColor = Color.Gainsboro;
            sc.Panel2.BackColor = Color.WhiteSmoke;

            var statusLabel = new Label();
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            statusLabel.Location = new Point(5, 6);
            statusLabel.Text = "Status: " + req.Status.ToString();

            var ci = req.CommissionType;

            var detailsLabel = new Label();
            detailsLabel.AutoSize = true;
            detailsLabel.Font = new Font("Segoe UI", 9F);
            detailsLabel.Location = new Point(5, 30);
            detailsLabel.MaximumSize = new Size(sc.Panel1.Width - 20, 0);

            string needByText;
            if (ci.NeedByDate.HasValue)
            {
                var dt = ci.NeedByDate.Value;
                if (dt.Date < DateTime.Today)
                    needByText = $"Need by: {dt.ToString("dd/MM/yyyy")} (Past deadline)";
                else
                    needByText = $"Need by: {dt.ToString("dd/MM/yyyy")}";
            }
            else
            {
                needByText = "Need by: Not specified";
            }

            detailsLabel.Text =
                $"Client: {req.Client.ClientName}\n" +
                $"Email: {req.Client.ClientEmail}\n" +
                $"Crop: {ci.CropType}\n" +
                $"Number of Characters: {ci.NumberOFCharacters}\n" +
                $"Has Background: {(ci.HasBackground ? "Yes" : "No")}\n" +
                $"Estimated Price: {ci.EstimatedPrice:C}\n" +
                needByText;

            sc.Panel1.Controls.Add(statusLabel);
            sc.Panel1.Controls.Add(detailsLabel);
            sc.Panel1.AutoScroll = true;

            var rightSummary = new Label();
            rightSummary.AutoSize = true;
            rightSummary.Font = new Font("Segoe UI", 10F);
            rightSummary.Location = new Point(5, 6);
            rightSummary.Text = $"ID: {req.Id}";
            sc.Panel2.Controls.Add(rightSummary);

            return sc;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminDashboard_Shown(object sender, EventArgs e)
        {
            // When the form first becomes visible, build the commission overview for admins
            if (SessionManager.IsAdmin())
            {
                BuildCommissionOverview();
            }
        }
    }
}
