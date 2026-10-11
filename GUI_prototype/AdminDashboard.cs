using System;
using System.Windows.Forms;
using ArtCommissionApplication_Prototype;

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

        // Stubs for designer-wired events (keeps designer-generated wiring intact)
        private void tabHome_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
    }
}
