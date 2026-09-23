using Microsoft.Data.Sqlite;
using System.Data;


namespace GUI_prototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadQueueDatabaseData();
        }

        private void RequestComm_Click(object sender, EventArgs e)
        {
            Form2 newWindow = new Form2();

            newWindow.Show();
            // this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // load queue from data base into visuals
        private string connectionString = @"Data Source=commissions.db;"; // sienna - will need to update to the path it makes
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

        private void ReloadQueue()
        {
            LoadQueueDatabaseData();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            ReloadQueue();
        }
    }
}
