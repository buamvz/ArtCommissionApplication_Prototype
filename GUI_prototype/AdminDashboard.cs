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
    }
}
