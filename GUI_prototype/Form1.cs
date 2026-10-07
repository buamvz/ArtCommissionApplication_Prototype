using Microsoft.Data.Sqlite;
using System.Data;
using ArtCommissionApplication_Prototype;
using System.Drawing;


namespace GUI_prototype
{
    public partial class Form1 : Form
    {
        // UI elements for simple role switching in the prototype
        private Label currentUserLabel;
        private Button signInClientButton;
        private Button signInArtistButton;
        private Button signInAdminButton;
        private Button signOutButton;

        public Form1()
        {
            InitializeComponent();
            // create simple role-switch UI (for prototype/testing)
            //CreateRoleControls();
            // subscribe to session changes so UI can react
            //SessionManager.UserChanged += OnUserChanged;
            //UpdateRoleUI();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (CommissionRepository.CommissionTableExists())
                LoadQueueDatabaseData();
        }

        //private void OnUserChanged(User? user)
        //{
        //    if (InvokeRequired)
        //    {
        //        Invoke(new Action(() => OnUserChanged(user)));
        //        return;
        //    }

        //    UpdateRoleUI();
        //}

        //private void CreateRoleControls()
        //{
        //    // Current user label
        //    currentUserLabel = new Label
        //    {
        //        AutoSize = true,
        //        Location = new Point(520, 10),
        //        Name = "currentUserLabel",
        //        Text = "Not signed in",
        //        Font = new Font(Font.FontFamily, 9, FontStyle.Bold)
        //    };
        //    Controls.Add(currentUserLabel);

        //    // Sign in as client
        //    signInClientButton = new Button
        //    {
        //        Location = new Point(520, 40),
        //        Size = new Size(120, 28),
        //        Text = "Sign in Client"
        //    };
        //    signInClientButton.Click += (s, e) =>
        //    {
        //        var user = new User { Username = "client_user", Role = Role.Client };
        //        SessionManager.SetUser(user);
        //    };
        //    Controls.Add(signInClientButton);

        //    // Sign in as artist
        //    signInArtistButton = new Button
        //    {
        //        Location = new Point(520, 72),
        //        Size = new Size(120, 28),
        //        Text = "Sign in Artist"
        //    };
        //    signInArtistButton.Click += (s, e) =>
        //    {
        //        var user = new User { Username = "artist_user", Role = Role.Artist };
        //        SessionManager.SetUser(user);
        //    };
        //    Controls.Add(signInArtistButton);

        //    // Sign in as admin
        //    signInAdminButton = new Button
        //    {
        //        Location = new Point(520, 104),
        //        Size = new Size(120, 28),
        //        Text = "Sign in Admin"
        //    };
        //    signInAdminButton.Click += (s, e) =>
        //    {
        //        var user = new User { Username = "admin_user", Role = Role.Admin };
        //        SessionManager.SetUser(user);
        //    };
        //    Controls.Add(signInAdminButton);

        //    signOutButton = new Button
        //    {
        //        Location = new Point(520, 136),
        //        Size = new Size(120, 28),
        //        Text = "Sign out"
        //    };
        //    signOutButton.Click += (s, e) => SessionManager.Logout();
        //    Controls.Add(signOutButton);
        //}

        //private void UpdateRoleUI()
        //{
        //    var user = SessionManager.LoggedInUser;
        //    if (user == null)
        //    {
        //        currentUserLabel.Text = "Not signed in";
        //        RequestComm.Enabled = true; // allow anonymous to request? keep enabled for prototype
        //    }
        //    else
        //    {
        //        currentUserLabel.Text = $"Signed in: {user.Username} ({user.Role})";
        //        // Only clients can create commission requests in this model
        //        RequestComm.Enabled = SessionManager.IsClient();
        //    }
        //}

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

        private void tabMyCommissions_Client_Click(object sender, EventArgs e)
        {

        }
    }
}
