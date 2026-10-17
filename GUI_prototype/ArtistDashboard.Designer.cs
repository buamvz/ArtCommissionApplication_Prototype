namespace GUI_prototype
{
    partial class ArtistDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtistDashboard));
            artistTabs = new TabControl();
            workspaceTab = new TabPage();
            ArtistCommissionsDashboard = new TabControl();
            incomingCommissions = new TabPage();
            artistPendingCommissionsList = new FlowLayoutPanel();
            splitContainer2 = new SplitContainer();
            label2 = new Label();
            label3 = new Label();
            reloadCommRequestsButton = new Button();
            incomingCommissionsLabel = new Label();
            acceptedCommissions = new TabPage();
            reloadAcceptedCommsButton = new Button();
            artistAcceptedCommissionsList = new FlowLayoutPanel();
            acceptedCommissionsLabel = new Label();
            publicQueue = new TabPage();
            reloadQueueButton = new Button();
            artistViewQueueGrid = new DataGridView();
            label4 = new Label();
            conversationTab = new TabPage();
            rejectedCommissions = new TabPage();
            artistRejectedCommissionsList = new FlowLayoutPanel();
            reloadRejectedCommsButton = new Button();
            rejectedCommissionsLabel = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            artistInformationTab = new TabPage();
            clientProfileTabs = new TabControl();
            artistProfile = new TabPage();
            saveChangesWarning = new Label();
            saveChangesButton = new Button();
            editPfpButton = new Button();
            labelImagSize = new Label();
            labelProfilePicture = new Label();
            pictureBox1 = new PictureBox();
            bioTextBox = new TextBox();
            emailTextBox = new TextBox();
            usernameTextBox = new TextBox();
            labelBio = new Label();
            labelEmail = new Label();
            labelUsername = new Label();
            label5 = new Label();
            tosEditor = new TabPage();
            clientProfileLabel = new Label();
            labelUserProfile = new Label();
            galleryEditor = new TabPage();
            artistTabs.SuspendLayout();
            workspaceTab.SuspendLayout();
            ArtistCommissionsDashboard.SuspendLayout();
            incomingCommissions.SuspendLayout();
            artistPendingCommissionsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.SuspendLayout();
            acceptedCommissions.SuspendLayout();
            publicQueue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)artistViewQueueGrid).BeginInit();
            rejectedCommissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            artistInformationTab.SuspendLayout();
            clientProfileTabs.SuspendLayout();
            artistProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tosEditor.SuspendLayout();
            SuspendLayout();
            // 
            // artistTabs
            // 
            artistTabs.Controls.Add(workspaceTab);
            artistTabs.Controls.Add(artistInformationTab);
            artistTabs.Dock = DockStyle.Fill;
            artistTabs.Location = new Point(0, 0);
            artistTabs.Name = "artistTabs";
            artistTabs.SelectedIndex = 0;
            artistTabs.Size = new Size(800, 493);
            artistTabs.SizeMode = TabSizeMode.FillToRight;
            artistTabs.TabIndex = 10;
            // 
            // workspaceTab
            // 
            workspaceTab.Controls.Add(ArtistCommissionsDashboard);
            workspaceTab.Controls.Add(pictureBox2);
            workspaceTab.Controls.Add(label1);
            workspaceTab.Location = new Point(4, 24);
            workspaceTab.Name = "workspaceTab";
            workspaceTab.Padding = new Padding(3);
            workspaceTab.Size = new Size(792, 465);
            workspaceTab.TabIndex = 0;
            workspaceTab.Text = "Workspace";
            workspaceTab.UseVisualStyleBackColor = true;
            // 
            // ArtistCommissionsDashboard
            // 
            ArtistCommissionsDashboard.Controls.Add(incomingCommissions);
            ArtistCommissionsDashboard.Controls.Add(acceptedCommissions);
            ArtistCommissionsDashboard.Controls.Add(publicQueue);
            ArtistCommissionsDashboard.Controls.Add(conversationTab);
            ArtistCommissionsDashboard.Controls.Add(rejectedCommissions);
            ArtistCommissionsDashboard.Dock = DockStyle.Fill;
            ArtistCommissionsDashboard.Location = new Point(3, 58);
            ArtistCommissionsDashboard.Name = "ArtistCommissionsDashboard";
            ArtistCommissionsDashboard.SelectedIndex = 0;
            ArtistCommissionsDashboard.Size = new Size(786, 404);
            ArtistCommissionsDashboard.TabIndex = 9;
            // 
            // incomingCommissions
            // 
            incomingCommissions.Controls.Add(artistPendingCommissionsList);
            incomingCommissions.Controls.Add(reloadCommRequestsButton);
            incomingCommissions.Controls.Add(incomingCommissionsLabel);
            incomingCommissions.Location = new Point(4, 24);
            incomingCommissions.Name = "incomingCommissions";
            incomingCommissions.Padding = new Padding(3);
            incomingCommissions.Size = new Size(778, 376);
            incomingCommissions.TabIndex = 6;
            incomingCommissions.Text = "Incoming Commission Requests";
            incomingCommissions.UseVisualStyleBackColor = true;
            // 
            // artistPendingCommissionsList
            // 
            artistPendingCommissionsList.AutoScroll = true;
            artistPendingCommissionsList.Controls.Add(splitContainer2);
            artistPendingCommissionsList.Dock = DockStyle.Fill;
            artistPendingCommissionsList.Location = new Point(3, 42);
            artistPendingCommissionsList.Name = "artistPendingCommissionsList";
            artistPendingCommissionsList.Size = new Size(772, 331);
            artistPendingCommissionsList.TabIndex = 11;
            // 
            // splitContainer2
            // 
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.AutoScroll = true;
            splitContainer2.Panel1.BackColor = Color.Gainsboro;
            splitContainer2.Panel1.Controls.Add(label2);
            splitContainer2.Panel1.Controls.Add(label3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.WhiteSmoke;
            splitContainer2.Size = new Size(766, 130);
            splitContainer2.SplitterDistance = 348;
            splitContainer2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 133);
            label2.TabIndex = 1;
            label2.Text = "Name:\r\nEmail:\r\nCommission Details:\r\n\r\nDescription:\r\n\r\nThank you!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 19);
            label3.TabIndex = 0;
            label3.Text = "Status: Pending";
            // 
            // reloadCommRequestsButton
            // 
            reloadCommRequestsButton.Location = new Point(525, 13);
            reloadCommRequestsButton.Name = "reloadCommRequestsButton";
            reloadCommRequestsButton.Size = new Size(230, 23);
            reloadCommRequestsButton.TabIndex = 10;
            reloadCommRequestsButton.Text = "Reload Commissions";
            reloadCommRequestsButton.UseVisualStyleBackColor = true;
            reloadCommRequestsButton.Click += reloadCommRequestsButton_Click;
            // 
            // incomingCommissionsLabel
            // 
            incomingCommissionsLabel.BackColor = Color.FromArgb(224, 224, 224);
            incomingCommissionsLabel.Dock = DockStyle.Top;
            incomingCommissionsLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            incomingCommissionsLabel.Location = new Point(3, 3);
            incomingCommissionsLabel.Name = "incomingCommissionsLabel";
            incomingCommissionsLabel.Padding = new Padding(10);
            incomingCommissionsLabel.Size = new Size(772, 39);
            incomingCommissionsLabel.TabIndex = 8;
            incomingCommissionsLabel.Text = "Pending Commissions";
            // 
            // acceptedCommissions
            // 
            acceptedCommissions.Controls.Add(reloadAcceptedCommsButton);
            acceptedCommissions.Controls.Add(artistAcceptedCommissionsList);
            acceptedCommissions.Controls.Add(acceptedCommissionsLabel);
            acceptedCommissions.Location = new Point(4, 24);
            acceptedCommissions.Name = "acceptedCommissions";
            acceptedCommissions.Padding = new Padding(3);
            acceptedCommissions.Size = new Size(778, 376);
            acceptedCommissions.TabIndex = 1;
            acceptedCommissions.Text = "Accepted Commissions";
            acceptedCommissions.UseVisualStyleBackColor = true;
            // 
            // reloadAcceptedCommsButton
            // 
            reloadAcceptedCommsButton.Location = new Point(525, 10);
            reloadAcceptedCommsButton.Name = "reloadAcceptedCommsButton";
            reloadAcceptedCommsButton.Size = new Size(230, 23);
            reloadAcceptedCommsButton.TabIndex = 11;
            reloadAcceptedCommsButton.Text = "Reload Commissions";
            reloadAcceptedCommsButton.UseVisualStyleBackColor = true;
            reloadAcceptedCommsButton.Click += reloadAcceptedCommsButton_Click;
            // 
            // artistAcceptedCommissionsList
            // 
            artistAcceptedCommissionsList.AutoScroll = true;
            artistAcceptedCommissionsList.Dock = DockStyle.Fill;
            artistAcceptedCommissionsList.Location = new Point(3, 42);
            artistAcceptedCommissionsList.Name = "artistAcceptedCommissionsList";
            artistAcceptedCommissionsList.Size = new Size(772, 331);
            artistAcceptedCommissionsList.TabIndex = 12;
            // 
            // acceptedCommissionsLabel
            // 
            acceptedCommissionsLabel.BackColor = Color.FromArgb(224, 224, 224);
            acceptedCommissionsLabel.Dock = DockStyle.Top;
            acceptedCommissionsLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            acceptedCommissionsLabel.Location = new Point(3, 3);
            acceptedCommissionsLabel.Name = "acceptedCommissionsLabel";
            acceptedCommissionsLabel.Padding = new Padding(10);
            acceptedCommissionsLabel.Size = new Size(772, 39);
            acceptedCommissionsLabel.TabIndex = 9;
            acceptedCommissionsLabel.Text = "Accepted Commissions";
            // 
            // publicQueue
            // 
            publicQueue.AutoScroll = true;
            publicQueue.Controls.Add(reloadQueueButton);
            publicQueue.Controls.Add(artistViewQueueGrid);
            publicQueue.Controls.Add(label4);
            publicQueue.Location = new Point(4, 24);
            publicQueue.Name = "publicQueue";
            publicQueue.Size = new Size(778, 376);
            publicQueue.TabIndex = 7;
            publicQueue.Text = "Public Queue";
            publicQueue.UseVisualStyleBackColor = true;
            // 
            // reloadQueueButton
            // 
            reloadQueueButton.Location = new Point(602, 10);
            reloadQueueButton.Name = "reloadQueueButton";
            reloadQueueButton.Size = new Size(161, 23);
            reloadQueueButton.TabIndex = 12;
            reloadQueueButton.Text = "Reload Queue";
            reloadQueueButton.UseVisualStyleBackColor = true;
            reloadQueueButton.Click += reloadQueueButton_Click;
            // 
            // artistViewQueueGrid
            // 
            artistViewQueueGrid.AllowUserToAddRows = false;
            artistViewQueueGrid.AllowUserToDeleteRows = false;
            artistViewQueueGrid.AllowUserToResizeColumns = false;
            artistViewQueueGrid.AllowUserToResizeRows = false;
            artistViewQueueGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            artistViewQueueGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            artistViewQueueGrid.Dock = DockStyle.Fill;
            artistViewQueueGrid.Location = new Point(0, 39);
            artistViewQueueGrid.Name = "artistViewQueueGrid";
            artistViewQueueGrid.ReadOnly = true;
            artistViewQueueGrid.Size = new Size(778, 337);
            artistViewQueueGrid.TabIndex = 11;
            artistViewQueueGrid.CellFormatting += ArtistViewQueueGrid_CellFormatting;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(224, 224, 224);
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(10);
            label4.Size = new Size(778, 39);
            label4.TabIndex = 10;
            label4.Text = "Accepted Commissions";
            // 
            // conversationTab
            // 
            conversationTab.Location = new Point(4, 24);
            conversationTab.Name = "conversationTab";
            conversationTab.Size = new Size(778, 376);
            conversationTab.TabIndex = 8;
            conversationTab.Text = "Conversation";
            conversationTab.UseVisualStyleBackColor = true;
            // 
            // rejectedCommissions
            // 
            rejectedCommissions.Controls.Add(artistRejectedCommissionsList);
            rejectedCommissions.Controls.Add(reloadRejectedCommsButton);
            rejectedCommissions.Controls.Add(rejectedCommissionsLabel);
            rejectedCommissions.Location = new Point(4, 24);
            rejectedCommissions.Name = "rejectedCommissions";
            rejectedCommissions.Size = new Size(778, 376);
            rejectedCommissions.TabIndex = 9;
            rejectedCommissions.Text = "Rejected Commissions";
            rejectedCommissions.UseVisualStyleBackColor = true;
            // 
            // artistRejectedCommissionsList
            // 
            artistRejectedCommissionsList.AutoScroll = true;
            artistRejectedCommissionsList.Dock = DockStyle.Fill;
            artistRejectedCommissionsList.Location = new Point(0, 39);
            artistRejectedCommissionsList.Name = "artistRejectedCommissionsList";
            artistRejectedCommissionsList.Size = new Size(778, 337);
            artistRejectedCommissionsList.TabIndex = 14;
            // 
            // reloadRejectedCommsButton
            // 
            reloadRejectedCommsButton.Location = new Point(534, 10);
            reloadRejectedCommsButton.Name = "reloadRejectedCommsButton";
            reloadRejectedCommsButton.Size = new Size(230, 23);
            reloadRejectedCommsButton.TabIndex = 13;
            reloadRejectedCommsButton.Text = "Reload Commissions";
            reloadRejectedCommsButton.UseVisualStyleBackColor = true;
            reloadRejectedCommsButton.Click += reloadRejectedCommsButton_Click;
            // 
            // rejectedCommissionsLabel
            // 
            rejectedCommissionsLabel.BackColor = Color.FromArgb(224, 224, 224);
            rejectedCommissionsLabel.Dock = DockStyle.Top;
            rejectedCommissionsLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rejectedCommissionsLabel.Location = new Point(0, 0);
            rejectedCommissionsLabel.Name = "rejectedCommissionsLabel";
            rejectedCommissionsLabel.Padding = new Padding(10);
            rejectedCommissionsLabel.Size = new Size(778, 39);
            rejectedCommissionsLabel.TabIndex = 12;
            rejectedCommissionsLabel.Text = "Recently Rejected Commissions";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Image = Properties.Resources.JellyPhlox;
            pictureBox2.Location = new Point(7, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.LavenderBlush;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkMagenta;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(786, 55);
            label1.TabIndex = 3;
            label1.Text = "JellyPhlox Commission Dashboard";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // artistInformationTab
            // 
            artistInformationTab.Controls.Add(clientProfileTabs);
            artistInformationTab.Location = new Point(4, 24);
            artistInformationTab.Name = "artistInformationTab";
            artistInformationTab.Padding = new Padding(3);
            artistInformationTab.Size = new Size(792, 465);
            artistInformationTab.TabIndex = 1;
            artistInformationTab.Text = "My Artist Information";
            artistInformationTab.UseVisualStyleBackColor = true;
            // 
            // clientProfileTabs
            // 
            clientProfileTabs.Controls.Add(artistProfile);
            clientProfileTabs.Controls.Add(tosEditor);
            clientProfileTabs.Controls.Add(galleryEditor);
            clientProfileTabs.Location = new Point(3, 6);
            clientProfileTabs.Name = "clientProfileTabs";
            clientProfileTabs.SelectedIndex = 0;
            clientProfileTabs.Size = new Size(793, 467);
            clientProfileTabs.TabIndex = 0;
            // 
            // artistProfile
            // 
            artistProfile.Controls.Add(saveChangesWarning);
            artistProfile.Controls.Add(saveChangesButton);
            artistProfile.Controls.Add(editPfpButton);
            artistProfile.Controls.Add(labelImagSize);
            artistProfile.Controls.Add(labelProfilePicture);
            artistProfile.Controls.Add(pictureBox1);
            artistProfile.Controls.Add(bioTextBox);
            artistProfile.Controls.Add(emailTextBox);
            artistProfile.Controls.Add(usernameTextBox);
            artistProfile.Controls.Add(labelBio);
            artistProfile.Controls.Add(labelEmail);
            artistProfile.Controls.Add(labelUsername);
            artistProfile.Controls.Add(label5);
            artistProfile.Location = new Point(4, 24);
            artistProfile.Name = "artistProfile";
            artistProfile.Padding = new Padding(3);
            artistProfile.Size = new Size(785, 439);
            artistProfile.TabIndex = 6;
            artistProfile.Text = "Artist Profile";
            artistProfile.UseVisualStyleBackColor = true;
            // 
            // saveChangesWarning
            // 
            saveChangesWarning.AutoSize = true;
            saveChangesWarning.Location = new Point(439, 323);
            saveChangesWarning.Name = "saveChangesWarning";
            saveChangesWarning.Size = new Size(155, 15);
            saveChangesWarning.TabIndex = 22;
            saveChangesWarning.Text = "Remember to save changes.";
            saveChangesWarning.TextAlign = ContentAlignment.TopRight;
            // 
            // saveChangesButton
            // 
            saveChangesButton.Location = new Point(600, 319);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(160, 23);
            saveChangesButton.TabIndex = 21;
            saveChangesButton.Text = "Save Changes to Profile";
            saveChangesButton.UseVisualStyleBackColor = true;
            saveChangesButton.Click += saveChangesButton_Click;
            // 
            // editPfpButton
            // 
            editPfpButton.Location = new Point(600, 100);
            editPfpButton.Name = "editPfpButton";
            editPfpButton.Size = new Size(124, 23);
            editPfpButton.TabIndex = 20;
            editPfpButton.Text = "Edit Profile Picture";
            editPfpButton.UseVisualStyleBackColor = true;
            // 
            // labelImagSize
            // 
            labelImagSize.AutoSize = true;
            labelImagSize.Location = new Point(600, 82);
            labelImagSize.Name = "labelImagSize";
            labelImagSize.Size = new Size(74, 15);
            labelImagSize.TabIndex = 19;
            labelImagSize.Text = "Size: 140x140";
            // 
            // labelProfilePicture
            // 
            labelProfilePicture.AutoSize = true;
            labelProfilePicture.Location = new Point(454, 56);
            labelProfilePicture.Name = "labelProfilePicture";
            labelProfilePicture.Size = new Size(84, 15);
            labelProfilePicture.TabIndex = 18;
            labelProfilePicture.Text = "Profile Picutre:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(454, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 140);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // bioTextBox
            // 
            bioTextBox.Location = new Point(91, 119);
            bioTextBox.MaxLength = 3000;
            bioTextBox.Multiline = true;
            bioTextBox.Name = "bioTextBox";
            bioTextBox.Size = new Size(322, 182);
            bioTextBox.TabIndex = 16;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(91, 82);
            emailTextBox.MaxLength = 30;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(322, 23);
            emailTextBox.TabIndex = 15;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(91, 53);
            usernameTextBox.MaxLength = 30;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(322, 23);
            usernameTextBox.TabIndex = 14;
            // 
            // labelBio
            // 
            labelBio.AutoSize = true;
            labelBio.Location = new Point(22, 122);
            labelBio.Name = "labelBio";
            labelBio.Size = new Size(27, 15);
            labelBio.TabIndex = 13;
            labelBio.Text = "Bio:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(22, 85);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 15);
            labelEmail.TabIndex = 12;
            labelEmail.Text = "Email:";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(22, 56);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(63, 15);
            labelUsername.TabIndex = 11;
            labelUsername.Text = "Username:";
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(224, 224, 224);
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 3);
            label5.Name = "label5";
            label5.Padding = new Padding(10);
            label5.Size = new Size(779, 39);
            label5.TabIndex = 10;
            label5.Text = "User Profile";
            // 
            // tosEditor
            // 
            tosEditor.Controls.Add(clientProfileLabel);
            tosEditor.Controls.Add(labelUserProfile);
            tosEditor.Location = new Point(4, 24);
            tosEditor.Name = "tosEditor";
            tosEditor.Padding = new Padding(3);
            tosEditor.Size = new Size(785, 439);
            tosEditor.TabIndex = 1;
            tosEditor.Text = "My Terms Of Service";
            tosEditor.UseVisualStyleBackColor = true;
            // 
            // clientProfileLabel
            // 
            clientProfileLabel.AutoSize = true;
            clientProfileLabel.Location = new Point(9, 55);
            clientProfileLabel.Name = "clientProfileLabel";
            clientProfileLabel.Size = new Size(240, 90);
            clientProfileLabel.TabIndex = 10;
            clientProfileLabel.Text = "Username:\r\nPassword: *** (try change to however many)\r\n\r\nAssociated Emails:\r\n\r\n[Reset password]\r\n";
            // 
            // labelUserProfile
            // 
            labelUserProfile.BackColor = Color.FromArgb(224, 224, 224);
            labelUserProfile.Dock = DockStyle.Top;
            labelUserProfile.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserProfile.Location = new Point(3, 3);
            labelUserProfile.Name = "labelUserProfile";
            labelUserProfile.Padding = new Padding(10);
            labelUserProfile.Size = new Size(779, 39);
            labelUserProfile.TabIndex = 9;
            labelUserProfile.Text = "User Profile";
            // 
            // galleryEditor
            // 
            galleryEditor.Location = new Point(4, 24);
            galleryEditor.Name = "galleryEditor";
            galleryEditor.Size = new Size(785, 439);
            galleryEditor.TabIndex = 7;
            galleryEditor.Text = "Gallery Images";
            galleryEditor.UseVisualStyleBackColor = true;
            // 
            // ArtistDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 493);
            Controls.Add(artistTabs);
            Name = "ArtistDashboard";
            Text = "ArtistDashboard";
            artistTabs.ResumeLayout(false);
            workspaceTab.ResumeLayout(false);
            ArtistCommissionsDashboard.ResumeLayout(false);
            incomingCommissions.ResumeLayout(false);
            artistPendingCommissionsList.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            acceptedCommissions.ResumeLayout(false);
            publicQueue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)artistViewQueueGrid).EndInit();
            rejectedCommissions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            artistInformationTab.ResumeLayout(false);
            clientProfileTabs.ResumeLayout(false);
            artistProfile.ResumeLayout(false);
            artistProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tosEditor.ResumeLayout(false);
            tosEditor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl artistTabs;
        private TabPage workspaceTab;
        private PictureBox pictureBox2;
        private Label label1;
        private TabPage artistInformationTab;
        private TabControl clientProfileTabs;
        private TabPage artistProfile;
        private FlowLayoutPanel userMyCommissionsList;
        private Button reloadCommissionsButton;
        private TabPage tosEditor;
        private Label clientProfileLabel;
        private Label labelUserProfile;
        private TabControl ArtistCommissionsDashboard;
        private TabPage incomingCommissions;
        private FlowLayoutPanel artistPendingCommissionsList;
        private SplitContainer splitContainer2;
        private Label label2;
        private Label label3;
        private Button reloadCommRequestsButton;
        private Label incomingCommissionsLabel;
        private TabPage acceptedCommissions;
        private TabPage publicQueue;
        private TabPage conversationTab;
        private FlowLayoutPanel artistAcceptedCommissionsList;
        private Label acceptedCommissionsLabel;
        private Button reloadAcceptedCommsButton;
        private Label label4;
        private Button reloadQueueButton;
        private DataGridView artistViewQueueGrid;
        private TabPage rejectedCommissions;
        private FlowLayoutPanel artistRejectedCommissionsList;
        private Button reloadRejectedCommsButton;
        private SplitContainer splitContainer1;
        private Label labelUsername;
        private Button editPfpButton;
        private Label rejectedCommissionsLabel;
        private TabPage galleryEditor;
        private Label label5;
        private Label labelEmail;
        private TextBox usernameTextBox;
        private Label labelBio;
        private TextBox bioTextBox;
        private TextBox emailTextBox;
        private Label labelProfilePicture;
        private PictureBox pictureBox1;
        private Label labelImagSize;
        private Button saveChangesButton;
        private Label saveChangesWarning;
    }
}