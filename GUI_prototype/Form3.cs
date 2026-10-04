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
        private SystemRole? claimedRole = null;

        public Form3()
        {
            InitializeComponent();
            LoginPanel.Visible = false;


            // update debug label when session changes
            SessionManager.UserChanged += (u) => {
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

        private void button3_Click(object sender, EventArgs e)
        {
            // sign in
        }

        private void UpdateDebugLabel()
        {
            if (SessionManager.CurrentActiveUser != null)
            {
                debugLabel.Text = $"Signed in: {SessionManager.CurrentActiveUser.Username} ({SessionManager.CurrentActiveUser.Role})";
            }
            else if (claimedRole != null)
            {
                debugLabel.Text = $"Claiming role: {claimedRole}";
            }
            else
            {
                debugLabel.Text = "Current User Is: None";
            }

        }

        private void backToSelectUserButton_Click(object sender, EventArgs e)
        {
            UserTypePanel.Visible = true;
            LoginPanel.Visible = false;
        }
    }
}
