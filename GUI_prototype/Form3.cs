using ArtCommissionApplication_Prototype;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_prototype
{
    public partial class Form3 : Form
    {
        // sienna - claimed role will track what the current user plans to sign in as and will be used for the debug label
        private SystemRole? claimedRole = null;

        private string username;
        private string password;

        public Form3()
        {
            InitializeComponent();
            LoginPanel.Visible = false;


            // update debug label when session changes
            SessionManager.UserChanged += (u) =>
            {
                if (InvokeRequired) Invoke(new Action(() => UpdateDebugLabel())); else UpdateDebugLabel();
            };
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            //Form1 newWindow = new Form1();

            //newWindow.Show();
            //this.Hide();

            claimedRole = SystemRole.Client;
            UserTypePanel.Visible = false;
            LoginPanel.Visible = true;

            UpdateDebugLabel();
        }

        private void ArtistButton_Click(object sender, EventArgs e)
        {
            claimedRole = SystemRole.Artist;
            UserTypePanel.Visible = false;
            LoginPanel.Visible = true;

            UpdateDebugLabel();
        }
        private void AdminButton_Click(object sender, EventArgs e)
        {
            claimedRole = SystemRole.Admin;
            UserTypePanel.Visible = false;
            LoginPanel.Visible = true;

            UpdateDebugLabel();
        }

        // sienna - sign up with inputed in
        private void signupButton_Click(object sender, EventArgs e)
        {
            // sienna - prevent username with special characters (numbers and letters only)
            if (usernameInput.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                MessageBox.Show("Username can only contain letters and digits.");
                return;
            }
            // sienna - make sure user has (more) secure password.
            if (passwordInput.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.");
                return;
            }

            username = usernameInput.Text;
            password = passwordInput.Text;

            if (username != null && password != null && claimedRole.HasValue)
                SessionManager.SignUp(username, password, claimedRole.Value);
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameInput.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                MessageBox.Show("Username can only contain letters and digits.");
                return;
            }
            // sienna - make sure user has (more) secure password.
            if (passwordInput.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.");
                return;
            }

            username = usernameInput.Text;
            password = passwordInput.Text;

            if (username != null && password != null)
                SessionManager.Login(username, password);
        }

        private void UpdateDebugLabel()
        {
            if (SessionManager.CurrentActiveUser != null)
            {
                debugLabel.Text = $"Signed in: {SessionManager.CurrentActiveUser.Username} ({SessionManager.CurrentActiveUser.Role})";
            }
            else if (claimedRole != null)
            {
                debugLabel.Text = $"Current User Is: {claimedRole}";
            }

        }

        private void backToSelectUserButton_Click(object sender, EventArgs e)
        {
            UserTypePanel.Visible = true;
            LoginPanel.Visible = false;
        }

 
    }
}
