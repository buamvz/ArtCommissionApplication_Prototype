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
            pictureBox2 = new PictureBox();
            label1 = new Label();
            artistInformationTab = new TabPage();
            clientProfileTabs = new TabControl();
            userMyCommissionsView = new TabPage();
            userMyCommissionsList = new FlowLayoutPanel();
            reloadCommissionsButton = new Button();
            userProfile = new TabPage();
            clientProfileLabel = new Label();
            labelUserProfile = new Label();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            artistInformationTab.SuspendLayout();
            clientProfileTabs.SuspendLayout();
            userMyCommissionsView.SuspendLayout();
            userProfile.SuspendLayout();
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
            splitContainer2.Size = new Size(759, 130);
            splitContainer2.SplitterDistance = 345;
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
            reloadCommRequestsButton.Text = "Reload My Commissions";
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
            reloadAcceptedCommsButton.Location = new Point(525, 6);
            reloadAcceptedCommsButton.Name = "reloadAcceptedCommsButton";
            reloadAcceptedCommsButton.Size = new Size(230, 23);
            reloadAcceptedCommsButton.TabIndex = 11;
            reloadAcceptedCommsButton.Text = "Reload My Commissions";
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
            // 
            // artistViewQueueGrid
            // 
            artistViewQueueGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            artistViewQueueGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            artistViewQueueGrid.Dock = DockStyle.Fill;
            artistViewQueueGrid.Location = new Point(0, 39);
            artistViewQueueGrid.Name = "artistViewQueueGrid";
            artistViewQueueGrid.Size = new Size(778, 337);
            artistViewQueueGrid.TabIndex = 11;
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
            label1.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkMagenta;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(786, 55);
            label1.TabIndex = 3;
            label1.Text = "Commission @JellyPhlox";
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
            clientProfileTabs.Controls.Add(userMyCommissionsView);
            clientProfileTabs.Controls.Add(userProfile);
            clientProfileTabs.Location = new Point(3, 6);
            clientProfileTabs.Name = "clientProfileTabs";
            clientProfileTabs.SelectedIndex = 0;
            clientProfileTabs.Size = new Size(793, 467);
            clientProfileTabs.TabIndex = 0;
            // 
            // userMyCommissionsView
            // 
            userMyCommissionsView.Controls.Add(userMyCommissionsList);
            userMyCommissionsView.Controls.Add(reloadCommissionsButton);
            userMyCommissionsView.Location = new Point(4, 24);
            userMyCommissionsView.Name = "userMyCommissionsView";
            userMyCommissionsView.Padding = new Padding(3);
            userMyCommissionsView.Size = new Size(785, 439);
            userMyCommissionsView.TabIndex = 6;
            userMyCommissionsView.Text = "My Commission Requests";
            userMyCommissionsView.UseVisualStyleBackColor = true;
            // 
            // userMyCommissionsList
            // 
            userMyCommissionsList.Dock = DockStyle.Fill;
            userMyCommissionsList.Location = new Point(3, 3);
            userMyCommissionsList.Name = "userMyCommissionsList";
            userMyCommissionsList.Size = new Size(779, 433);
            userMyCommissionsList.TabIndex = 11;
            // 
            // reloadCommissionsButton
            // 
            reloadCommissionsButton.Location = new Point(547, 6);
            reloadCommissionsButton.Name = "reloadCommissionsButton";
            reloadCommissionsButton.Size = new Size(230, 23);
            reloadCommissionsButton.TabIndex = 10;
            reloadCommissionsButton.Text = "Reload My Commissions";
            reloadCommissionsButton.UseVisualStyleBackColor = true;
            // 
            // userProfile
            // 
            userProfile.Controls.Add(clientProfileLabel);
            userProfile.Controls.Add(labelUserProfile);
            userProfile.Location = new Point(4, 24);
            userProfile.Name = "userProfile";
            userProfile.Padding = new Padding(3);
            userProfile.Size = new Size(785, 439);
            userProfile.TabIndex = 1;
            userProfile.Text = "User Profile";
            userProfile.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            artistInformationTab.ResumeLayout(false);
            clientProfileTabs.ResumeLayout(false);
            userMyCommissionsView.ResumeLayout(false);
            userProfile.ResumeLayout(false);
            userProfile.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl artistTabs;
        private TabPage workspaceTab;
        private PictureBox pictureBox2;
        private Label label1;
        private TabPage artistInformationTab;
        private TabControl clientProfileTabs;
        private TabPage userMyCommissionsView;
        private FlowLayoutPanel userMyCommissionsList;
        private Button reloadCommissionsButton;
        private TabPage userProfile;
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
        private DataGridView artistViewQueueGrid;
        private Button reloadQueueButton;
    }
}