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
            ClientButton = new Button();
            ArtistButton = new Button();
            AdminButton = new Button();
            UserTypePanel = new Panel();
            LoginPanel = new Panel();
            backToSelectUserButton = new Button();
            usernameLable = new Label();
            passwordLabel = new Label();
            passwordInput = new TextBox();
            usernameInput = new TextBox();
            loginButton = new Button();
            signupButton = new Button();
            debugLabel = new Label();
            UserTypePanel.SuspendLayout();
            LoginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ClientButton
            // 
            ClientButton.Location = new Point(242, 152);
            ClientButton.Name = "ClientButton";
            ClientButton.Size = new Size(145, 75);
            ClientButton.TabIndex = 0;
            ClientButton.Text = "Client";
            ClientButton.UseVisualStyleBackColor = true;
            ClientButton.Click += ClientButton_Click;
            // 
            // ArtistButton
            // 
            ArtistButton.Location = new Point(403, 152);
            ArtistButton.Name = "ArtistButton";
            ArtistButton.Size = new Size(145, 75);
            ArtistButton.TabIndex = 1;
            ArtistButton.Text = "Artist";
            ArtistButton.UseVisualStyleBackColor = true;
            ArtistButton.Click += ArtistButton_Click;
            // 
            // AdminButton
            // 
            AdminButton.Location = new Point(315, 249);
            AdminButton.Name = "AdminButton";
            AdminButton.Size = new Size(145, 45);
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
            UserTypePanel.Location = new Point(14, 16);
            UserTypePanel.Margin = new Padding(3, 4, 3, 4);
            UserTypePanel.Name = "UserTypePanel";
            UserTypePanel.Size = new Size(773, 419);
            UserTypePanel.TabIndex = 3;
            // 
            // LoginPanel
            // 
            LoginPanel.Controls.Add(backToSelectUserButton);
            LoginPanel.Controls.Add(usernameLable);
            LoginPanel.Controls.Add(passwordLabel);
            LoginPanel.Controls.Add(passwordInput);
            LoginPanel.Controls.Add(usernameInput);
            LoginPanel.Controls.Add(loginButton);
            LoginPanel.Controls.Add(signupButton);
            LoginPanel.Location = new Point(14, 16);
            LoginPanel.Margin = new Padding(3, 4, 3, 4);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(773, 419);
            LoginPanel.TabIndex = 4;
            LoginPanel.Visible = false;
            // 
            // backToSelectUserButton
            // 
            backToSelectUserButton.Location = new Point(14, 19);
            backToSelectUserButton.Margin = new Padding(3, 4, 3, 4);
            backToSelectUserButton.Name = "backToSelectUserButton";
            backToSelectUserButton.Size = new Size(86, 31);
            backToSelectUserButton.TabIndex = 8;
            backToSelectUserButton.Text = "Back";
            backToSelectUserButton.UseVisualStyleBackColor = true;
            backToSelectUserButton.Click += backToSelectUserButton_Click;
            // 
            // usernameLable
            // 
            usernameLable.AutoSize = true;
            usernameLable.Location = new Point(255, 107);
            usernameLable.Name = "usernameLable";
            usernameLable.Size = new Size(78, 20);
            usernameLable.TabIndex = 7;
            usernameLable.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(251, 172);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(73, 20);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Password:";
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(251, 196);
            passwordInput.Margin = new Padding(3, 4, 3, 4);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '*';
            passwordInput.Size = new Size(297, 27);
            passwordInput.TabIndex = 5;
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(251, 131);
            usernameInput.Margin = new Padding(3, 4, 3, 4);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(297, 27);
            usernameInput.TabIndex = 4;
            usernameInput.TextChanged += usernameInput_TextChanged;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(403, 249);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(145, 45);
            loginButton.TabIndex = 3;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // signupButton
            // 
            signupButton.Location = new Point(251, 249);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(145, 45);
            signupButton.TabIndex = 2;
            signupButton.Text = "Sign Up";
            signupButton.UseVisualStyleBackColor = true;
            signupButton.Click += signupButton_Click;
            // 
            // debugLabel
            // 
            debugLabel.AutoSize = true;
            debugLabel.Location = new Point(14, 447);
            debugLabel.Name = "debugLabel";
            debugLabel.Size = new Size(107, 20);
            debugLabel.TabIndex = 5;
            debugLabel.Text = "Current User Is:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 479);
            Controls.Add(debugLabel);
            Controls.Add(LoginPanel);
            Controls.Add(UserTypePanel);
            Name = "Form3";
            Text = "Form3";
            UserTypePanel.ResumeLayout(false);
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
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
    }
}