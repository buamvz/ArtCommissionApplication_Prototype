namespace GUI_prototype
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ClientButton = new Button();
            ArtistButton = new Button();
            AdminButton = new Button();
            UserTypePanel = new Panel();
            allUsersButton = new Button();
            LoginPanel = new Panel();
            continueButton = new Button();
            backToSelectUserButton = new Button();
            usernameLable = new Label();
            passwordLabel = new Label();
            passwordInput = new TextBox();
            usernameInput = new TextBox();
            loginButton = new Button();
            signupButton = new Button();
            debugLabel = new Label();
            usernameErrorProvider = new ErrorProvider(components);
            userListPanel = new Panel();
            debugButton1 = new Button();
            panel1 = new Panel();
            deleteUserButton = new Button();
            userListGrid = new DataGridView();
            loadUsersButton = new Button();
            usersListLabel = new Label();
            backToLogin = new Button();
            UserTypePanel.SuspendLayout();
            LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usernameErrorProvider).BeginInit();
            userListPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userListGrid).BeginInit();
            SuspendLayout();
            // 
            // ClientButton
            // 
            ClientButton.Location = new Point(207, 114);
            ClientButton.Margin = new Padding(3, 2, 3, 2);
            ClientButton.Name = "ClientButton";
            ClientButton.Size = new Size(127, 56);
            ClientButton.TabIndex = 0;
            ClientButton.Text = "Client";
            ClientButton.UseVisualStyleBackColor = true;
            ClientButton.Click += ClientButton_Click;
            // 
            // ArtistButton
            // 
            ArtistButton.Location = new Point(340, 114);
            ArtistButton.Margin = new Padding(3, 2, 3, 2);
            ArtistButton.Name = "ArtistButton";
            ArtistButton.Size = new Size(127, 56);
            ArtistButton.TabIndex = 1;
            ArtistButton.Text = "Artist";
            ArtistButton.UseVisualStyleBackColor = true;
            ArtistButton.Click += ArtistButton_Click;
            // 
            // AdminButton
            // 
            AdminButton.Location = new Point(273, 186);
            AdminButton.Margin = new Padding(3, 2, 3, 2);
            AdminButton.Name = "AdminButton";
            AdminButton.Size = new Size(127, 34);
            AdminButton.TabIndex = 2;
            AdminButton.Text = "Admin";
            AdminButton.UseVisualStyleBackColor = true;
            AdminButton.Click += AdminButton_Click;
            // 
            // UserTypePanel
            // 
            UserTypePanel.Controls.Add(ClientButton);
            UserTypePanel.Controls.Add(AdminButton);
            UserTypePanel.Controls.Add(ArtistButton);
            UserTypePanel.Controls.Add(allUsersButton);
            UserTypePanel.Location = new Point(12, 12);
            UserTypePanel.Name = "UserTypePanel";
            UserTypePanel.Size = new Size(676, 314);
            UserTypePanel.TabIndex = 3;
            // 
            // allUsersButton
            // 
            allUsersButton.Location = new Point(18, 17);
            allUsersButton.Margin = new Padding(3, 2, 3, 2);
            allUsersButton.Name = "allUsersButton";
            allUsersButton.Size = new Size(127, 34);
            allUsersButton.TabIndex = 5;
            allUsersButton.Text = "See All Users";
            allUsersButton.UseVisualStyleBackColor = true;
            allUsersButton.Click += allUsersButton_Click;
            // 
            // LoginPanel
            // 
            LoginPanel.Controls.Add(continueButton);
            LoginPanel.Controls.Add(backToSelectUserButton);
            LoginPanel.Controls.Add(usernameLable);
            LoginPanel.Controls.Add(passwordLabel);
            LoginPanel.Controls.Add(passwordInput);
            LoginPanel.Controls.Add(usernameInput);
            LoginPanel.Controls.Add(loginButton);
            LoginPanel.Controls.Add(signupButton);
            LoginPanel.Location = new Point(12, 12);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(676, 314);
            LoginPanel.TabIndex = 4;
            LoginPanel.Visible = false;
            // 
            // continueButton
            // 
            continueButton.Enabled = false;
            continueButton.Location = new Point(220, 236);
            continueButton.Margin = new Padding(3, 2, 3, 2);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(260, 34);
            continueButton.TabIndex = 9;
            continueButton.Text = "Continue";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += continueButton_Click;
            // 
            // backToSelectUserButton
            // 
            backToSelectUserButton.Location = new Point(12, 14);
            backToSelectUserButton.Name = "backToSelectUserButton";
            backToSelectUserButton.Size = new Size(75, 23);
            backToSelectUserButton.TabIndex = 8;
            backToSelectUserButton.Text = "Back";
            backToSelectUserButton.UseVisualStyleBackColor = true;
            backToSelectUserButton.Click += backToSelectUserButton_Click;
            // 
            // usernameLable
            // 
            usernameLable.AutoSize = true;
            usernameLable.Location = new Point(223, 80);
            usernameLable.Name = "usernameLable";
            usernameLable.Size = new Size(63, 15);
            usernameLable.TabIndex = 7;
            usernameLable.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(220, 129);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(60, 15);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Password:";
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(220, 147);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '*';
            passwordInput.Size = new Size(260, 23);
            passwordInput.TabIndex = 5;
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(220, 98);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(260, 23);
            usernameInput.TabIndex = 4;
            usernameInput.TextChanged += usernameInput_TextChanged;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(353, 187);
            loginButton.Margin = new Padding(3, 2, 3, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(127, 34);
            loginButton.TabIndex = 3;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // signupButton
            // 
            signupButton.Location = new Point(220, 187);
            signupButton.Margin = new Padding(3, 2, 3, 2);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(127, 34);
            signupButton.TabIndex = 2;
            signupButton.Text = "Sign Up";
            signupButton.UseVisualStyleBackColor = true;
            signupButton.Click += signupButton_Click;
            // 
            // debugLabel
            // 
            debugLabel.AutoSize = true;
            debugLabel.Location = new Point(12, 335);
            debugLabel.Name = "debugLabel";
            debugLabel.Size = new Size(87, 15);
            debugLabel.TabIndex = 5;
            debugLabel.Text = "Current User Is:";
            // 
            // usernameErrorProvider
            // 
            usernameErrorProvider.BlinkRate = 150;
            usernameErrorProvider.ContainerControl = this;
            // 
            // userListPanel
            // 
            userListPanel.Controls.Add(debugButton1);
            userListPanel.Controls.Add(panel1);
            userListPanel.Controls.Add(backToLogin);
            userListPanel.Location = new Point(12, 12);
            userListPanel.Name = "userListPanel";
            userListPanel.Size = new Size(676, 314);
            userListPanel.TabIndex = 10;
            // 
            // debugButton1
            // 
            debugButton1.Location = new Point(526, 14);
            debugButton1.Name = "debugButton1";
            debugButton1.Size = new Size(132, 23);
            debugButton1.TabIndex = 15;
            debugButton1.Text = "Debug - db path";
            debugButton1.UseVisualStyleBackColor = true;
            debugButton1.Click += debugButton1_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(deleteUserButton);
            panel1.Controls.Add(userListGrid);
            panel1.Controls.Add(loadUsersButton);
            panel1.Controls.Add(usersListLabel);
            panel1.Location = new Point(0, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 271);
            panel1.TabIndex = 14;
            // 
            // deleteUserButton
            // 
            deleteUserButton.Location = new Point(388, 10);
            deleteUserButton.Name = "deleteUserButton";
            deleteUserButton.Size = new Size(132, 23);
            deleteUserButton.TabIndex = 15;
            deleteUserButton.Text = "Delete User";
            deleteUserButton.UseVisualStyleBackColor = true;
            deleteUserButton.Click += deleteUserButton_Click;
            // 
            // userListGrid
            // 
            userListGrid.AllowUserToAddRows = false;
            userListGrid.AllowUserToDeleteRows = false;
            userListGrid.AllowUserToResizeColumns = false;
            userListGrid.AllowUserToResizeRows = false;
            userListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userListGrid.Dock = DockStyle.Fill;
            userListGrid.Location = new Point(0, 39);
            userListGrid.MultiSelect = false;
            userListGrid.Name = "userListGrid";
            userListGrid.ReadOnly = true;
            userListGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userListGrid.Size = new Size(676, 232);
            userListGrid.TabIndex = 14;
            // 
            // loadUsersButton
            // 
            loadUsersButton.Location = new Point(526, 10);
            loadUsersButton.Name = "loadUsersButton";
            loadUsersButton.Size = new Size(132, 23);
            loadUsersButton.TabIndex = 12;
            loadUsersButton.Text = "Load Users";
            loadUsersButton.UseVisualStyleBackColor = true;
            // 
            // usersListLabel
            // 
            usersListLabel.BackColor = Color.FromArgb(224, 224, 224);
            usersListLabel.Dock = DockStyle.Top;
            usersListLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usersListLabel.Location = new Point(0, 0);
            usersListLabel.Name = "usersListLabel";
            usersListLabel.Padding = new Padding(10);
            usersListLabel.Size = new Size(676, 39);
            usersListLabel.TabIndex = 8;
            usersListLabel.Text = "Users List";
            // 
            // backToLogin
            // 
            backToLogin.Location = new Point(18, 14);
            backToLogin.Name = "backToLogin";
            backToLogin.Size = new Size(132, 23);
            backToLogin.TabIndex = 11;
            backToLogin.Text = "Back to Login";
            backToLogin.UseVisualStyleBackColor = true;
            backToLogin.Click += loadUsersButton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 359);
            Controls.Add(userListPanel);
            Controls.Add(debugLabel);
            Controls.Add(LoginPanel);
            Controls.Add(UserTypePanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form3";
            Text = "Form3";
            UserTypePanel.ResumeLayout(false);
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usernameErrorProvider).EndInit();
            userListPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userListGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ClientButton;
        private Button ArtistButton;
        private Button AdminButton;
        private Panel UserTypePanel;
        private Panel LoginPanel;
        private Button signupButton;
        private Button loginButton;
        private Label usernameLable;
        private Label passwordLabel;
        private TextBox passwordInput;
        private TextBox usernameInput;
        private Label debugLabel;
        private Button backToSelectUserButton;
        private Button continueButton;
        private ErrorProvider usernameErrorProvider;
        private Button allUsersButton;
        private Panel userListPanel;
        private Button backToLogin;
        private Label usersListLabel;
        private Button loadUsersButton;
        private Panel panel1;
        private DataGridView userListGrid;
        private Button debugButton1;
        private Button deleteUserButton;
    }
}