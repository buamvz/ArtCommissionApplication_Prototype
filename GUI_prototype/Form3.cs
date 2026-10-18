using ArtCommissionApplication_Prototype;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_prototype
{
    public partial class LoginForm : Form
    {
        // sienna - claimed role will track what the current user plans to sign in as and will be used for the debug label
        private SystemRole? claimedRole = null;

        private string username;
        private string password;

        private readonly ErrorProvider errorProvider;

        public LoginForm()
        {
            InitializeComponent();
            LoginPanel.Visible = false;
            // userListPanel.Visible = false;
            UserTypePanel.Visible = true;

            errorProvider = new ErrorProvider(this);

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

            errorProvider.Clear();
            // sienna - prevent username with special characters (numbers and letters only)
            if (usernameInput.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                errorProvider.SetError(usernameInput, "Username can only contain letters and digits.");
                return;
            }
            // sienna - make sure user has (more) secure password.
            if (passwordInput.Text.Length < 8)
            {
                errorProvider.SetError(passwordInput, "Password must be at least 8 characters long.");
                return;
            }

            username = usernameInput.Text;
            password = passwordInput.Text;

            if (username != null && password != null && claimedRole.HasValue)
            {
                bool created = SessionManager.SignUp(username, password, claimedRole.Value);
                if (!created)
                {
                    errorProvider.SetError(usernameInput, "Username or Role already exists.");
                    return;
                }

                // on success, update UI similar to login
                backToSelectUserButton.Text = "Logout";
                continueButton.Enabled = true;
            }
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (usernameInput.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                errorProvider.SetError(usernameInput, "Username can only contain letters and digits.");
                return;
            }
            // sienna - make sure user has (more) secure password.
            if (passwordInput.Text.Length < 8)
            {
                errorProvider.SetError(passwordInput, "Password must be at least 8 characters long.");
                return;
            }

            username = usernameInput.Text;
            password = passwordInput.Text;

            if (username != null && password != null && claimedRole.HasValue)
            {
                // Call Login once and act on the result. The previous code called Login twice.
                bool loggedIn = SessionManager.Login(username, password, claimedRole.Value);
                if (!loggedIn)
                {
                    MessageBox.Show("User not found.");
                    return;
                }

                backToSelectUserButton.Text = "Logout";
                continueButton.Enabled = true;
            }
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
            backToSelectUser();
        }

        private void backToSelectUser()
        {
            UserTypePanel.Visible = true;
            // userListPanel.Visible = false;
            LoginPanel.Visible = false;
            SessionManager.Logout();
            backToSelectUserButton.Text = "Back";
            continueButton.Enabled = false;
        }

        private void usernameInput_TextChanged(object sender, EventArgs e)
        {
            if (usernameInput.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                errorProvider.SetError(usernameInput, "Username can only contain letters and digits.");
                return;
            }
            else
            {
                errorProvider.Clear();
            }
        }

        //Brooke - Adding in continue cases for different roles so that the continue button can open different forms base off of the buinuess role rules
        private void continueButton_Click(object sender, EventArgs e)
        {
            // Make sure a user is actually logged in.
            if (SessionManager.CurrentActiveUser == null)
            {
                MessageBox.Show("Please log in before continuing.");
                return;
            }

            Form nextForm;

            // Choose the destination based on the authenticated user's role.
            switch (SessionManager.CurrentActiveUser.Role)
            {
                //Pulls roles from User emuns
                case SystemRole.Admin:
                    nextForm = new AdminDashboard();
                    break;

                //SIENNAAA CHANGE WHAT FORMS THESE ROLES GO TO LATER!!!!!!!!!!! 
                // sienna - OKAY I MADE ARTIST FORM
                case SystemRole.Client:
                    nextForm = new ClientDashboard();
                    break;
                case SystemRole.Artist:
                    // Keep the existing destination for now.
                    // Replace this with the separate role-specific forms later.
                    nextForm = new ArtistDashboard();
                    break;

                default:
                    MessageBox.Show("Your account does not have a valid role.");
                    return;
            }

            nextForm.Show();
            this.Hide();
        }

        // === User list view stuff (moved to admin dash) ===
        //private void ShowAllUsers()
        //{
        //    UserTypePanel.Visible = false;
        //    LoginPanel.Visible = false;
        //    userListPanel.Visible = true;

        //    loadUsers();
        //}

        //private void allUsersButton_Click(object sender, EventArgs e)
        //{
        //    ShowAllUsers();
        //}

        //private void loadUsersButton_Click(object sender, EventArgs e)
        //{
        //    backToSelectUser();
        //}

        //private void loadUsers()
        //{
        //    var users = UserRepository.GetAllUsers();

        //    userListGrid.Rows.Clear();
        //    userListGrid.Columns.Clear();

        //    userListGrid.Columns.Add("Username", "Username");
        //    userListGrid.Columns.Add("Role", "Role");
        //    userListGrid.Columns.Add("Hash", "Password Hash");
        //    userListGrid.Columns.Add("Salt", "Password Salt");
        //    foreach (var user in users)
        //    {
        //        userListGrid.Rows.Add(
        //            user.Username,
        //            user.Role.ToString(),
        //            user.PasswordHash,
        //            user.PasswordSalt
        //        );
        //    }
        //}

        //private void debugButton1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show(UserRepository.GetDatabasePath());
        //}

        //private void deleteUserButton_Click(object sender, EventArgs e)
        //{
        //    if (userListGrid.SelectedRows.Count == 0)
        //    {
        //        MessageBox.Show("Please select a user first.", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }

        //    string username = userListGrid.SelectedRows[0].Cells["Username"].Value.ToString();

        //    var result = MessageBox.Show($"Delete user '{username}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        //    if (result != DialogResult.Yes)
        //        return;

        //    // sienna - prevent from deleting current/active user
        //    if (SessionManager.CurrentActiveUser != null && username == SessionManager.CurrentActiveUser.Username)
        //    {
        //        MessageBox.Show("You cannot delete the currently logged in user.");
        //        return;
        //    }

        //    try
        //    {
        //        UserRepository.DeleteUser(username);

        //        loadUsers();

        //        MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Failed to delete user:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

    }
}
