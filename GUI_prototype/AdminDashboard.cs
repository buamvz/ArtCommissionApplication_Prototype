using System;
using System.Windows.Forms;
using ArtCommissionApplication_Prototype;

namespace GUI_prototype
{
    public class AdminDashboard : Form
    {
        private Label headerLabel;

        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.headerLabel = new Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Location = new System.Drawing.Point(16, 16);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(200, 20);
            this.headerLabel.Text = "Admin Dashboard";
            // 
            // AdminDashboard
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.headerLabel);
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();
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
    }
}
