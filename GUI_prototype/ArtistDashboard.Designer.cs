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
            ArtistCommissionsDashboardTabs = new TabControl();
            artistQueue = new TabPage();
            reloadQueueButton = new Button();
            artistViewQueueGrid = new DataGridView();
            label4 = new Label();
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
            conversationTab = new TabPage();
            completedCommissions = new TabPage();
            artistCompletedCommissionsList = new FlowLayoutPanel();
            reloadCompletedCommsButton = new Button();
            completedCommissionsLabel = new Label();
            rejectedCommissions = new TabPage();
            artistRejectedCommissionsList = new FlowLayoutPanel();
            reloadRejectedCommsButton = new Button();
            rejectedCommissionsLabel = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            artistInformationTab = new TabPage();
            artistProfileTabs = new TabControl();
            artistProfile = new TabPage();
            saveChangesWarning = new Label();
            saveChangesProfileButton = new Button();
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
            label10 = new Label();
            saveChangesTosButton = new Button();
            wontDrawTextBox = new TextBox();
            label9 = new Label();
            willDrawTextBox = new TextBox();
            label8 = new Label();
            label7 = new Label();
            termsTextBox = new TextBox();
            label6 = new Label();
            labelTermsOfService = new Label();
            galleryEditor = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox9 = new PictureBox();
            label11 = new Label();
            artistTabs.SuspendLayout();
            workspaceTab.SuspendLayout();
            ArtistCommissionsDashboardTabs.SuspendLayout();
            artistQueue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)artistViewQueueGrid).BeginInit();
            incomingCommissions.SuspendLayout();
            artistPendingCommissionsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.SuspendLayout();
            acceptedCommissions.SuspendLayout();
            completedCommissions.SuspendLayout();
            rejectedCommissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            artistInformationTab.SuspendLayout();
            artistProfileTabs.SuspendLayout();
            artistProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tosEditor.SuspendLayout();
            galleryEditor.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
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
            artistTabs.Size = new Size(800, 519);
            artistTabs.SizeMode = TabSizeMode.FillToRight;
            artistTabs.TabIndex = 10;
            artistTabs.SelectedIndexChanged += artistTabs_SelectedIndexChanged;
            // 
            // workspaceTab
            // 
            workspaceTab.Controls.Add(ArtistCommissionsDashboardTabs);
            workspaceTab.Controls.Add(pictureBox2);
            workspaceTab.Controls.Add(label1);
            workspaceTab.Controls.Add(pictureBox4);
            workspaceTab.Location = new Point(4, 24);
            workspaceTab.Name = "workspaceTab";
            workspaceTab.Padding = new Padding(3);
            workspaceTab.Size = new Size(792, 491);
            workspaceTab.TabIndex = 0;
            workspaceTab.Text = "Workspace";
            workspaceTab.UseVisualStyleBackColor = true;
            // 
            // ArtistCommissionsDashboardTabs
            // 
            ArtistCommissionsDashboardTabs.Controls.Add(artistQueue);
            ArtistCommissionsDashboardTabs.Controls.Add(incomingCommissions);
            ArtistCommissionsDashboardTabs.Controls.Add(acceptedCommissions);
            ArtistCommissionsDashboardTabs.Controls.Add(conversationTab);
            ArtistCommissionsDashboardTabs.Controls.Add(completedCommissions);
            ArtistCommissionsDashboardTabs.Controls.Add(rejectedCommissions);
            ArtistCommissionsDashboardTabs.Dock = DockStyle.Fill;
            ArtistCommissionsDashboardTabs.Location = new Point(3, 104);
            ArtistCommissionsDashboardTabs.Name = "ArtistCommissionsDashboardTabs";
            ArtistCommissionsDashboardTabs.SelectedIndex = 0;
            ArtistCommissionsDashboardTabs.Size = new Size(786, 384);
            ArtistCommissionsDashboardTabs.TabIndex = 9;
            ArtistCommissionsDashboardTabs.SelectedIndexChanged += ArtistCommissionsDashboardTabs_SelectedIndexChanged;
            // 
            // artistQueue
            // 
            artistQueue.AutoScroll = true;
            artistQueue.Controls.Add(reloadQueueButton);
            artistQueue.Controls.Add(artistViewQueueGrid);
            artistQueue.Controls.Add(label4);
            artistQueue.Location = new Point(4, 24);
            artistQueue.Name = "artistQueue";
            artistQueue.Size = new Size(778, 356);
            artistQueue.TabIndex = 7;
            artistQueue.Text = "Commissions Queue";
            artistQueue.UseVisualStyleBackColor = true;
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
            artistViewQueueGrid.Size = new Size(778, 317);
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
            label4.Text = "All Current Commissions";
            // 
            // incomingCommissions
            // 
            incomingCommissions.Controls.Add(artistPendingCommissionsList);
            incomingCommissions.Controls.Add(reloadCommRequestsButton);
            incomingCommissions.Controls.Add(incomingCommissionsLabel);
            incomingCommissions.Location = new Point(4, 24);
            incomingCommissions.Name = "incomingCommissions";
            incomingCommissions.Padding = new Padding(3);
            incomingCommissions.Size = new Size(778, 356);
            incomingCommissions.TabIndex = 6;
            incomingCommissions.Text = "Incoming Commissions";
            incomingCommissions.UseVisualStyleBackColor = true;
            // 
            // artistPendingCommissionsList
            // 
            artistPendingCommissionsList.AutoScroll = true;
            artistPendingCommissionsList.Controls.Add(splitContainer2);
            artistPendingCommissionsList.Dock = DockStyle.Fill;
            artistPendingCommissionsList.Location = new Point(3, 42);
            artistPendingCommissionsList.Name = "artistPendingCommissionsList";
            artistPendingCommissionsList.Size = new Size(772, 311);
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
            incomingCommissionsLabel.Text = "Incoming Commission Requests";
            // 
            // acceptedCommissions
            // 
            acceptedCommissions.Controls.Add(reloadAcceptedCommsButton);
            acceptedCommissions.Controls.Add(artistAcceptedCommissionsList);
            acceptedCommissions.Controls.Add(acceptedCommissionsLabel);
            acceptedCommissions.Location = new Point(4, 24);
            acceptedCommissions.Name = "acceptedCommissions";
            acceptedCommissions.Padding = new Padding(3);
            acceptedCommissions.Size = new Size(778, 356);
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
            artistAcceptedCommissionsList.Size = new Size(772, 311);
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
            // conversationTab
            // 
            conversationTab.Location = new Point(4, 24);
            conversationTab.Name = "conversationTab";
            conversationTab.Size = new Size(778, 356);
            conversationTab.TabIndex = 8;
            conversationTab.Text = "Conversation";
            conversationTab.UseVisualStyleBackColor = true;
            // 
            // completedCommissions
            // 
            completedCommissions.Controls.Add(artistCompletedCommissionsList);
            completedCommissions.Controls.Add(reloadCompletedCommsButton);
            completedCommissions.Controls.Add(completedCommissionsLabel);
            completedCommissions.Location = new Point(4, 24);
            completedCommissions.Name = "completedCommissions";
            completedCommissions.Size = new Size(778, 356);
            completedCommissions.TabIndex = 10;
            completedCommissions.Text = "Completed Commissions";
            completedCommissions.UseVisualStyleBackColor = true;
            // 
            // artistCompletedCommissionsList
            // 
            artistCompletedCommissionsList.AutoScroll = true;
            artistCompletedCommissionsList.Dock = DockStyle.Fill;
            artistCompletedCommissionsList.Location = new Point(0, 39);
            artistCompletedCommissionsList.Name = "artistCompletedCommissionsList";
            artistCompletedCommissionsList.Size = new Size(778, 317);
            artistCompletedCommissionsList.TabIndex = 13;
            // 
            // reloadCompletedCommsButton
            // 
            reloadCompletedCommsButton.Location = new Point(525, 10);
            reloadCompletedCommsButton.Name = "reloadCompletedCommsButton";
            reloadCompletedCommsButton.Size = new Size(230, 23);
            reloadCompletedCommsButton.TabIndex = 12;
            reloadCompletedCommsButton.Text = "Reload Commissions";
            reloadCompletedCommsButton.UseVisualStyleBackColor = true;
            reloadCompletedCommsButton.Click += reloadCompletedCommsButton_Click;
            // 
            // completedCommissionsLabel
            // 
            completedCommissionsLabel.BackColor = Color.FromArgb(224, 224, 224);
            completedCommissionsLabel.Dock = DockStyle.Top;
            completedCommissionsLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            completedCommissionsLabel.ForeColor = SystemColors.AppWorkspace;
            completedCommissionsLabel.Location = new Point(0, 0);
            completedCommissionsLabel.Name = "completedCommissionsLabel";
            completedCommissionsLabel.Padding = new Padding(10);
            completedCommissionsLabel.Size = new Size(778, 39);
            completedCommissionsLabel.TabIndex = 10;
            completedCommissionsLabel.Text = "Completed Commissions";
            // 
            // rejectedCommissions
            // 
            rejectedCommissions.Controls.Add(artistRejectedCommissionsList);
            rejectedCommissions.Controls.Add(reloadRejectedCommsButton);
            rejectedCommissions.Controls.Add(rejectedCommissionsLabel);
            rejectedCommissions.ForeColor = Color.Gray;
            rejectedCommissions.Location = new Point(4, 24);
            rejectedCommissions.Name = "rejectedCommissions";
            rejectedCommissions.Size = new Size(778, 356);
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
            artistRejectedCommissionsList.Size = new Size(778, 317);
            artistRejectedCommissionsList.TabIndex = 14;
            // 
            // reloadRejectedCommsButton
            // 
            reloadRejectedCommsButton.Location = new Point(525, 10);
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
            rejectedCommissionsLabel.Text = "Rejected Commissions";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Image = Properties.Resources.JellyPhlox;
            pictureBox2.Location = new Point(737, 52);
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
            label1.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkMagenta;
            label1.Location = new Point(3, 49);
            label1.Name = "label1";
            label1.Size = new Size(786, 55);
            label1.TabIndex = 3;
            label1.Text = "JellyPhlox Commission Dashboard";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.Dock = DockStyle.Top;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(786, 46);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // artistInformationTab
            // 
            artistInformationTab.Controls.Add(artistProfileTabs);
            artistInformationTab.Location = new Point(4, 24);
            artistInformationTab.Name = "artistInformationTab";
            artistInformationTab.Padding = new Padding(3);
            artistInformationTab.Size = new Size(792, 491);
            artistInformationTab.TabIndex = 1;
            artistInformationTab.Text = "My Artist Information";
            artistInformationTab.UseVisualStyleBackColor = true;
            // 
            // artistProfileTabs
            // 
            artistProfileTabs.Controls.Add(artistProfile);
            artistProfileTabs.Controls.Add(tosEditor);
            artistProfileTabs.Controls.Add(galleryEditor);
            artistProfileTabs.Location = new Point(3, 6);
            artistProfileTabs.Name = "artistProfileTabs";
            artistProfileTabs.SelectedIndex = 0;
            artistProfileTabs.Size = new Size(793, 485);
            artistProfileTabs.TabIndex = 0;
            artistProfileTabs.SelectedIndexChanged += artistProfileTabs_SelectedIndexChanged;
            // 
            // artistProfile
            // 
            artistProfile.Controls.Add(saveChangesWarning);
            artistProfile.Controls.Add(saveChangesProfileButton);
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
            artistProfile.Size = new Size(785, 457);
            artistProfile.TabIndex = 6;
            artistProfile.Text = "Artist Profile";
            artistProfile.UseVisualStyleBackColor = true;
            // 
            // saveChangesWarning
            // 
            saveChangesWarning.AutoSize = true;
            saveChangesWarning.ForeColor = SystemColors.AppWorkspace;
            saveChangesWarning.Location = new Point(439, 323);
            saveChangesWarning.Name = "saveChangesWarning";
            saveChangesWarning.Size = new Size(155, 15);
            saveChangesWarning.TabIndex = 22;
            saveChangesWarning.Text = "Remember to save changes.";
            saveChangesWarning.TextAlign = ContentAlignment.TopRight;
            // 
            // saveChangesProfileButton
            // 
            saveChangesProfileButton.Location = new Point(600, 319);
            saveChangesProfileButton.Name = "saveChangesProfileButton";
            saveChangesProfileButton.Size = new Size(160, 23);
            saveChangesProfileButton.TabIndex = 21;
            saveChangesProfileButton.Text = "Save Changes to Profile";
            saveChangesProfileButton.UseVisualStyleBackColor = true;
            saveChangesProfileButton.Click += saveChangesButton_Click;
            // 
            // editPfpButton
            // 
            editPfpButton.Location = new Point(600, 100);
            editPfpButton.Name = "editPfpButton";
            editPfpButton.Size = new Size(124, 23);
            editPfpButton.TabIndex = 20;
            editPfpButton.Text = "Edit Profile Picture";
            editPfpButton.UseVisualStyleBackColor = true;
            editPfpButton.Click += editPfpButton_Click;
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
            pictureBox1.Image = Properties.Resources.JellyPhlox;
            pictureBox1.Location = new Point(454, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
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
            tosEditor.Controls.Add(label10);
            tosEditor.Controls.Add(saveChangesTosButton);
            tosEditor.Controls.Add(wontDrawTextBox);
            tosEditor.Controls.Add(label9);
            tosEditor.Controls.Add(willDrawTextBox);
            tosEditor.Controls.Add(label8);
            tosEditor.Controls.Add(label7);
            tosEditor.Controls.Add(termsTextBox);
            tosEditor.Controls.Add(label6);
            tosEditor.Controls.Add(labelTermsOfService);
            tosEditor.Location = new Point(4, 24);
            tosEditor.Name = "tosEditor";
            tosEditor.Padding = new Padding(3);
            tosEditor.Size = new Size(785, 457);
            tosEditor.TabIndex = 1;
            tosEditor.Text = "My Terms Of Service";
            tosEditor.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.AppWorkspace;
            label10.Location = new Point(503, 92);
            label10.Name = "label10";
            label10.Size = new Size(155, 15);
            label10.TabIndex = 25;
            label10.Text = "Remember to save changes.";
            label10.TextAlign = ContentAlignment.TopRight;
            // 
            // saveChangesTosButton
            // 
            saveChangesTosButton.Location = new Point(664, 88);
            saveChangesTosButton.Name = "saveChangesTosButton";
            saveChangesTosButton.Size = new Size(104, 23);
            saveChangesTosButton.TabIndex = 24;
            saveChangesTosButton.Text = "Save Changes";
            saveChangesTosButton.UseVisualStyleBackColor = true;
            saveChangesTosButton.Click += saveChangesTosButton_Click;
            // 
            // wontDrawTextBox
            // 
            wontDrawTextBox.Location = new Point(608, 132);
            wontDrawTextBox.MaxLength = 3000;
            wontDrawTextBox.Multiline = true;
            wontDrawTextBox.Name = "wontDrawTextBox";
            wontDrawTextBox.Size = new Size(153, 316);
            wontDrawTextBox.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(608, 114);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 22;
            label9.Text = "Won't Draw:";
            // 
            // willDrawTextBox
            // 
            willDrawTextBox.Location = new Point(449, 132);
            willDrawTextBox.MaxLength = 3000;
            willDrawTextBox.Multiline = true;
            willDrawTextBox.Name = "willDrawTextBox";
            willDrawTextBox.Size = new Size(153, 316);
            willDrawTextBox.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(449, 114);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 20;
            label8.Text = "Will Draw:";
            // 
            // label7
            // 
            label7.Location = new Point(19, 54);
            label7.Name = "label7";
            label7.Size = new Size(758, 36);
            label7.TabIndex = 19;
            label7.Text = resources.GetString("label7.Text");
            // 
            // termsTextBox
            // 
            termsTextBox.Location = new Point(19, 132);
            termsTextBox.MaxLength = 3000;
            termsTextBox.Multiline = true;
            termsTextBox.Name = "termsTextBox";
            termsTextBox.Size = new Size(420, 316);
            termsTextBox.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 114);
            label6.Name = "label6";
            label6.Size = new Size(139, 15);
            label6.TabIndex = 17;
            label6.Text = "General Rules and Terms:";
            // 
            // labelTermsOfService
            // 
            labelTermsOfService.BackColor = Color.FromArgb(224, 224, 224);
            labelTermsOfService.Dock = DockStyle.Top;
            labelTermsOfService.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTermsOfService.Location = new Point(3, 3);
            labelTermsOfService.Name = "labelTermsOfService";
            labelTermsOfService.Padding = new Padding(10);
            labelTermsOfService.Size = new Size(779, 39);
            labelTermsOfService.TabIndex = 9;
            labelTermsOfService.Text = "Commission Terms of Service";
            // 
            // galleryEditor
            // 
            galleryEditor.Controls.Add(flowLayoutPanel1);
            galleryEditor.Controls.Add(label11);
            galleryEditor.Location = new Point(4, 24);
            galleryEditor.Name = "galleryEditor";
            galleryEditor.Size = new Size(785, 457);
            galleryEditor.TabIndex = 7;
            galleryEditor.Text = "Gallery Images";
            galleryEditor.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(pictureBox3);
            flowLayoutPanel1.Controls.Add(pictureBox5);
            flowLayoutPanel1.Controls.Add(pictureBox6);
            flowLayoutPanel1.Controls.Add(pictureBox8);
            flowLayoutPanel1.Controls.Add(pictureBox7);
            flowLayoutPanel1.Controls.Add(pictureBox9);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 39);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(785, 418);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.dottore;
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(189, 239);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.paradise;
            pictureBox5.Location = new Point(198, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(197, 239);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.kpopdh_zine;
            pictureBox6.Location = new Point(401, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(342, 239);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.artfight_3again2;
            pictureBox8.Location = new Point(3, 248);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(313, 253);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 5;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.corazon_zine;
            pictureBox7.Location = new Point(322, 248);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(187, 263);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 3;
            pictureBox7.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.artfight;
            pictureBox9.Location = new Point(515, 248);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(226, 259);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 4;
            pictureBox9.TabStop = false;
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(224, 224, 224);
            label11.Dock = DockStyle.Top;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Padding = new Padding(10);
            label11.Size = new Size(785, 39);
            label11.TabIndex = 13;
            label11.Text = "Samples of Work";
            // 
            // ArtistDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(artistTabs);
            Name = "ArtistDashboard";
            Text = "ArtistDashboard";
            artistTabs.ResumeLayout(false);
            workspaceTab.ResumeLayout(false);
            ArtistCommissionsDashboardTabs.ResumeLayout(false);
            artistQueue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)artistViewQueueGrid).EndInit();
            incomingCommissions.ResumeLayout(false);
            artistPendingCommissionsList.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            acceptedCommissions.ResumeLayout(false);
            completedCommissions.ResumeLayout(false);
            rejectedCommissions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            artistInformationTab.ResumeLayout(false);
            artistProfileTabs.ResumeLayout(false);
            artistProfile.ResumeLayout(false);
            artistProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tosEditor.ResumeLayout(false);
            tosEditor.PerformLayout();
            galleryEditor.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl artistTabs;
        private TabPage workspaceTab;
        private PictureBox pictureBox2;
        private Label label1;
        private TabPage artistInformationTab;
        private TabControl artistProfileTabs;
        private TabPage artistProfile;
        private FlowLayoutPanel userMyCommissionsList;
        private Button reloadCommissionsButton;
        private TabPage tosEditor;
        private Label labelTermsOfService;
        private TabControl ArtistCommissionsDashboardTabs;
        private TabPage incomingCommissions;
        private FlowLayoutPanel artistPendingCommissionsList;
        private SplitContainer splitContainer2;
        private Label label2;
        private Label label3;
        private Button reloadCommRequestsButton;
        private Label incomingCommissionsLabel;
        private TabPage acceptedCommissions;
        private TabPage artistQueue;
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
        private Button saveChangesProfileButton;
        private Label saveChangesWarning;
        private TextBox termsTextBox;
        private Label label6;
        private Label label7;
        private TextBox wontDrawTextBox;
        private Label label9;
        private TextBox willDrawTextBox;
        private Label label8;
        private Label label10;
        private Button saveChangesTosButton;
        private TabPage completedCommissions;
        private Label completedCommissionsLabel;
        private Button reloadCompletedCommsButton;
        private FlowLayoutPanel artistCompletedCommissionsList;
        private PictureBox pictureBox4;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox9;
        private Label label11;
    }
}