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

                // Update estimated tax display whenever the queue data is loaded
                UpdateEstimatedTaxDisplay();
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
            // Ensure tax label updates after manual reload
            UpdateEstimatedTaxDisplay();
        }

        // Update the estimated tax label based on Accepted commissions stored EstimatedPrice values.
        private void UpdateEstimatedTaxDisplay()
        {
            try
            {
                decimal tax = QualityStatisticsService.CalculateEstimatedTax();
                estimatedTaxLabel.Text = $"Estimated Tax on Accepted Commissions: {tax.ToString("C2")}";
            }
            catch
            {
                estimatedTaxLabel.Text = "Estimated Tax on Accepted Commissions: $0.00";
            }
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

        // --- Quality dashboards handlers ---
        private void reloadTypeDashboardButton_Click(object sender, EventArgs e)
        {
            BuildTypeCommissionsChart();
        }

        private void reloadYearlyDashboardButton_Click(object sender, EventArgs e)
        {
            BuildYearlyCommissionsChart();
        }

        private void BuildTypeCommissionsChart()
        {
            try
            {
                var stats = QualityStatisticsService.CalculateTypeStatistics();

                // Clear existing series and points
                typeCommissionsPieChart.Series.Clear();
                var series = new System.Windows.Forms.DataVisualization.Charting.Series("Types");
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                series.IsValueShownAsLabel = true;

                // Ensure ChartArea/Legend names are assigned so the series is rendered in the correct area
                if (typeCommissionsPieChart.ChartAreas.Count > 0)
                    series.ChartArea = typeCommissionsPieChart.ChartAreas[0].Name;
                if (typeCommissionsPieChart.Legends.Count > 0)
                    series.Legend = typeCommissionsPieChart.Legends[0].Name;

                foreach (var item in stats.Items)
                {
                    int idx = series.Points.AddY(item.Count);
                    var dp = series.Points[idx];
                    dp.Label = $"{item.CropType} ({item.Count})";
                    dp.ToolTip = $"{item.CropType}: {item.Count} ({item.PercentageOfTotal:F1}%) - Total: {item.TotalEstimatedPrice:C}";
                }

                typeCommissionsPieChart.Series.Add(series);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to build type chart: {ex.Message}", "Chart error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuildYearlyCommissionsChart()
        {
            try
            {
                var res = QualityStatisticsService.CalculateYearlyVolume();

                // Make sure the chart has a chart area.
                // Do NOT clear ChartAreas: the Designer already creates ChartArea2.
                if (yearlyCommissionsLineChart.ChartAreas.Count == 0)
                {
                    yearlyCommissionsLineChart.ChartAreas.Add(
                        new System.Windows.Forms.DataVisualization.Charting.ChartArea("ChartArea2"));
                }

                var chartArea = yearlyCommissionsLineChart.ChartAreas[0];

                // Remove the Designer's default series and any previously drawn lines.
                yearlyCommissionsLineChart.Series.Clear();

                // Make sure a legend exists.
                if (yearlyCommissionsLineChart.Legends.Count == 0)
                {
                    yearlyCommissionsLineChart.Legends.Add(
                        new System.Windows.Forms.DataVisualization.Charting.Legend("Legend1"));
                }

                string chartAreaName = chartArea.Name;
                string legendName = yearlyCommissionsLineChart.Legends[0].Name;

                // Use the first 12 abbreviated month names: January through December.
                var monthNames = System.Globalization.CultureInfo.CurrentCulture
                    .DateTimeFormat.AbbreviatedMonthNames
                    .Take(12)
                    .ToArray();

                // If there is no data, show a zero-valued line for the current year.
                if (res.Series == null || res.Series.Count == 0)
                {
                    res.Series.Add(new YearlyVolumeSeries
                    {
                        Year = DateTime.Today.Year,
                        MonthlyCounts = new int[12]
                    });
                }

                foreach (var yearData in res.Series.OrderBy(s => s.Year))
                {
                    var series = new System.Windows.Forms.DataVisualization.Charting.Series(
                        yearData.Year.ToString());

                    series.ChartType =
                        System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                    series.ChartArea = chartAreaName;
                    series.Legend = legendName;
                    series.BorderWidth = 3;
                    series.IsXValueIndexed = true;
                    series.MarkerStyle =
                        System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                    series.MarkerSize = 7;
                    series.IsValueShownAsLabel = true;

                    // Add exactly 12 points, including months with zero commissions.
                    for (int month = 0; month < 12; month++)
                    {
                        int count = month < yearData.MonthlyCounts.Length
                            ? yearData.MonthlyCounts[month]
                            : 0;

                        int pointIndex = series.Points.AddXY(month + 1, count);
                        var point = series.Points[pointIndex];

                        point.AxisLabel = monthNames[month];
                        point.ToolTip =
                            $"{monthNames[month]} {yearData.Year}: {count} commissions";
                    }

                    yearlyCommissionsLineChart.Series.Add(series);
                }

                // Configure the axes.
                chartArea.AxisX.Title = "Month";
                chartArea.AxisX.Interval = 1;
                chartArea.AxisX.Minimum = 1;
                chartArea.AxisX.Maximum = 12;
                chartArea.AxisX.MajorGrid.Enabled = false;

                chartArea.AxisY.Title = "Number of Commissions";
                chartArea.AxisY.Minimum = 0;
                chartArea.AxisY.Interval = 1;
                chartArea.AxisY.MajorGrid.Enabled = true;

                yearlyCommissionsLineChart.Legends[0].Enabled = true;
                yearlyCommissionsLineChart.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to build yearly chart: {ex.Message}",
                    "Chart error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // === User list ===

        private void ShowAllUsers()
        {
            loadUsers();
        }

        private void loadUsersButton_Click(object sender, EventArgs e)
        {
            ShowAllUsers();
        }

        private void loadUsers()
        {
            var users = UserRepository.GetAllUsers();

            userListGrid.Rows.Clear();
            userListGrid.Columns.Clear();

            userListGrid.Columns.Add("Username", "Username");
            userListGrid.Columns.Add("Role", "Role");
            userListGrid.Columns.Add("Hash", "Password Hash");
            userListGrid.Columns.Add("Salt", "Password Salt");
            foreach (var user in users)
            {
                userListGrid.Rows.Add(
                    user.Username,
                    user.Role.ToString(),
                    user.PasswordHash,
                    user.PasswordSalt
                );
            }
        }

        private void debugButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UserRepository.GetDatabasePath());
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (userListGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user first.", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string username = userListGrid.SelectedRows[0].Cells["Username"].Value.ToString();

            var result = MessageBox.Show($"Delete user '{username}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            // sienna - prevent from deleting current/active user
            if (SessionManager.CurrentActiveUser != null && username == SessionManager.CurrentActiveUser.Username)
            {
                MessageBox.Show("You cannot delete the currently logged in user.");
                return;
            }

            try
            {
                UserRepository.DeleteUser(username);

                loadUsers();

                MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to delete user:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // === Loading on tab change ===
        private void AdminCommissionsDashboard_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = AdminCommissionsDashboard.SelectedIndex;
            TabPage currentTab = AdminCommissionsDashboard.SelectedTab;

            if (currentTab == commissionOverview)
            {
                BuildCommissionOverview();
            }
            else if (currentTab == commissionTypeDashboard)
            {
                BuildTypeCommissionsChart();
            }
            else if (currentTab == yearlyCommissionsChart)
            {
                BuildYearlyCommissionsChart();
            }
            else if (currentTab == publicQueue)
            {
                ReloadQueue();
                UpdateEstimatedTaxDisplay();
            }
            else if (currentTab == allUsersTab)
            {
                loadUsers();
            }
        }
    }
}
