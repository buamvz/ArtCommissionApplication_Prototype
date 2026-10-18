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
            UserTypePanel = new Panel();
            ArtistButton = new Button();
            AdminButton = new Button();
            ClientButton = new Button();
            LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usernameErrorProvider).BeginInit();
            UserTypePanel.SuspendLayout();
            SuspendLayout();
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
            // UserTypePanel
            // 
            UserTypePanel.Controls.Add(ClientButton);
            UserTypePanel.Controls.Add(AdminButton);
            UserTypePanel.Controls.Add(ArtistButton);
            UserTypePanel.Location = new Point(12, 12);
            UserTypePanel.Name = "UserTypePanel";
            UserTypePanel.Size = new Size(676, 314);
            UserTypePanel.TabIndex = 3;
            // 
            // ArtistButton
            // 
            ArtistButton.Location = new Point(340, 116);
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
            AdminButton.Location = new Point(271, 176);
            AdminButton.Margin = new Padding(3, 2, 3, 2);
            AdminButton.Name = "AdminButton";
            AdminButton.Size = new Size(127, 34);
            AdminButton.TabIndex = 2;
            AdminButton.Text = "Admin";
            AdminButton.UseVisualStyleBackColor = true;
            AdminButton.Click += AdminButton_Click;
            // 
            // ClientButton
            // 
            ClientButton.Location = new Point(207, 116);
            ClientButton.Margin = new Padding(3, 2, 3, 2);
            ClientButton.Name = "ClientButton";
            ClientButton.Size = new Size(127, 56);
            ClientButton.TabIndex = 0;
            ClientButton.Text = "Client";
            ClientButton.UseVisualStyleBackColor = true;
            ClientButton.Click += ClientButton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 359);
            Controls.Add(UserTypePanel);
            Controls.Add(debugLabel);
            Controls.Add(LoginPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form3";
            Text = "Form3";
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usernameErrorProvider).EndInit();
            UserTypePanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Panel UserTypePanel;
        private Button ClientButton;
        private Button AdminButton;
        private Button ArtistButton;
    }
}