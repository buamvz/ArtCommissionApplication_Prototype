using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI_prototype
{
    partial class AdminDashboard
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

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            splitContainer1 = new SplitContainer();
            label12 = new Label();
            labelStatus = new Label();
            adminTabs = new TabControl();
            workspaceTab = new TabPage();
            ArtistCommissionsDashboard = new TabControl();
            commissionOverview = new TabPage();
            artistAdminViewCommissionsList = new FlowLayoutPanel();
            reloadCommOverviewButton = new Button();
            commissionOverviewLabel = new Label();
            acceptedCommissions = new TabPage();
            reloadAcceptedCommsButton = new Button();
            artistAcceptedCommissionsList = new FlowLayoutPanel();
            acceptedCommissionsLabel = new Label();
            publicQueue = new TabPage();
            reloadQueueButton = new Button();
            adminViewQueueGrid = new DataGridView();
            label4 = new Label();
            conversationTab = new TabPage();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            artistInformationTab = new TabPage();
            clientProfileTabs = new TabControl();
            userProfile = new TabPage();
            clientProfileLabel = new Label();
            labelUserProfile = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            adminTabs.SuspendLayout();
            workspaceTab.SuspendLayout();
            ArtistCommissionsDashboard.SuspendLayout();
            commissionOverview.SuspendLayout();
            artistAdminViewCommissionsList.SuspendLayout();
            // splitContainer2 removed; dynamic sections will be created at runtime
            acceptedCommissions.SuspendLayout();
            publicQueue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adminViewQueueGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            artistInformationTab.SuspendLayout();
            clientProfileTabs.SuspendLayout();
            userProfile.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(9, 9);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Size = new Size(898, 173);
            splitContainer1.SplitterDistance = 409;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.Location = new Point(6, 41);
            label12.Name = "label12";
            label12.Size = new Size(163, 92);
            label12.TabIndex = 1;
            label12.Text = "Name:\r\nEmail:\r\nCommission Details:\r\n\r\n";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelStatus.Location = new Point(6, 16);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(135, 23);
            labelStatus.TabIndex = 0;
            labelStatus.Text = "Status: Pending";
            // 
            // adminTabs
            // 
            adminTabs.Controls.Add(workspaceTab);
            adminTabs.Controls.Add(artistInformationTab);
            adminTabs.Dock = DockStyle.Fill;
            adminTabs.Location = new Point(0, 0);
            adminTabs.Margin = new Padding(3, 4, 3, 4);
            adminTabs.Name = "adminTabs";
            adminTabs.SelectedIndex = 0;
            adminTabs.Size = new Size(914, 609);
            adminTabs.SizeMode = TabSizeMode.FillToRight;
            adminTabs.TabIndex = 11;
            // 
            // workspaceTab
            // 
            workspaceTab.Controls.Add(ArtistCommissionsDashboard);
            workspaceTab.Controls.Add(pictureBox2);
            workspaceTab.Controls.Add(label1);
            workspaceTab.Location = new Point(4, 29);
            workspaceTab.Margin = new Padding(3, 4, 3, 4);
            workspaceTab.Name = "workspaceTab";
            workspaceTab.Padding = new Padding(3, 4, 3, 4);
            workspaceTab.Size = new Size(906, 576);
            workspaceTab.TabIndex = 0;
            workspaceTab.Text = "Workspace";
            workspaceTab.UseVisualStyleBackColor = true;
            // 
            // ArtistCommissionsDashboard
            // 
            ArtistCommissionsDashboard.Controls.Add(commissionOverview);
            ArtistCommissionsDashboard.Controls.Add(acceptedCommissions);
            ArtistCommissionsDashboard.Controls.Add(publicQueue);
            ArtistCommissionsDashboard.Controls.Add(conversationTab);
            ArtistCommissionsDashboard.Dock = DockStyle.Fill;
            ArtistCommissionsDashboard.Location = new Point(3, 77);
            ArtistCommissionsDashboard.Margin = new Padding(3, 4, 3, 4);
            ArtistCommissionsDashboard.Name = "ArtistCommissionsDashboard";
            ArtistCommissionsDashboard.SelectedIndex = 0;
            ArtistCommissionsDashboard.Size = new Size(900, 495);
            ArtistCommissionsDashboard.TabIndex = 10;
            // 
            // commissionOverview
            // 
            commissionOverview.Controls.Add(artistAdminViewCommissionsList);
            commissionOverview.Controls.Add(reloadCommOverviewButton);
            commissionOverview.Controls.Add(commissionOverviewLabel);
            commissionOverview.Location = new Point(4, 29);
            commissionOverview.Margin = new Padding(3, 4, 3, 4);
            commissionOverview.Name = "commissionOverview";
            commissionOverview.Padding = new Padding(3, 4, 3, 4);
            commissionOverview.Size = new Size(892, 462);
            commissionOverview.TabIndex = 6;
            commissionOverview.Text = "Commission Overview";
            commissionOverview.UseVisualStyleBackColor = true;
            // 
            // artistAdminViewCommissionsList
            // 
            artistAdminViewCommissionsList.AutoScroll = true;
            artistAdminViewCommissionsList.Dock = DockStyle.Fill;
            artistAdminViewCommissionsList.Location = new Point(3, 56);
            artistAdminViewCommissionsList.Margin = new Padding(3, 4, 3, 4);
            artistAdminViewCommissionsList.Name = "artistAdminViewCommissionsList";
            artistAdminViewCommissionsList.Size = new Size(886, 402);
            artistAdminViewCommissionsList.TabIndex = 11;
            // 
            // splitContainer2 removed; placeholder controls label2/label3 no longer used
            // 
            // label2
            // 
            // label2 removed
            // 
            // label3
            // 
            //label3.AutoSize = true;
            //label3.Dock = DockStyle.Fill;
            //label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            //label3.Location = new Point(0, 0);
            //label3.Name = "label3";
            //label3.Size = new Size(135, 23);
            //label3.TabIndex = 0;
            //label3.Text = "Status: Pending";
            // 
            // reloadCommOverviewButton
            // 
            reloadCommOverviewButton.Location = new Point(600, 17);
            reloadCommOverviewButton.Margin = new Padding(3, 4, 3, 4);
            reloadCommOverviewButton.Name = "reloadCommOverviewButton";
            reloadCommOverviewButton.Size = new Size(263, 31);
            reloadCommOverviewButton.TabIndex = 10;
            reloadCommOverviewButton.Text = "Reload Commissions Overview";
            reloadCommOverviewButton.UseVisualStyleBackColor = true;
            reloadCommOverviewButton.Click += reloadCommOverviewButton_Click;
            // 
            // commissionOverviewLabel
            // 
            commissionOverviewLabel.BackColor = Color.FromArgb(224, 224, 224);
            commissionOverviewLabel.Dock = DockStyle.Top;
            commissionOverviewLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            commissionOverviewLabel.Location = new Point(3, 4);
            commissionOverviewLabel.Name = "commissionOverviewLabel";
            commissionOverviewLabel.Padding = new Padding(11, 13, 11, 13);
            commissionOverviewLabel.Size = new Size(886, 52);
            commissionOverviewLabel.TabIndex = 8;
            commissionOverviewLabel.Text = "Admin Commission Overview";
            // 
            // acceptedCommissions
            // 
            acceptedCommissions.Controls.Add(reloadAcceptedCommsButton);
            acceptedCommissions.Controls.Add(artistAcceptedCommissionsList);
            acceptedCommissions.Controls.Add(acceptedCommissionsLabel);
            acceptedCommissions.Location = new Point(4, 29);
            acceptedCommissions.Margin = new Padding(3, 4, 3, 4);
            acceptedCommissions.Name = "acceptedCommissions";
            acceptedCommissions.Padding = new Padding(3, 4, 3, 4);
            acceptedCommissions.Size = new Size(892, 462);
            acceptedCommissions.TabIndex = 1;
            acceptedCommissions.Text = "Accepted Commissions";
            acceptedCommissions.UseVisualStyleBackColor = true;
            // 
            // reloadAcceptedCommsButton
            // 
            reloadAcceptedCommsButton.Location = new Point(600, 8);
            reloadAcceptedCommsButton.Margin = new Padding(3, 4, 3, 4);
            reloadAcceptedCommsButton.Name = "reloadAcceptedCommsButton";
            reloadAcceptedCommsButton.Size = new Size(263, 31);
            reloadAcceptedCommsButton.TabIndex = 11;
            reloadAcceptedCommsButton.Text = "Reload My Commissions";
            reloadAcceptedCommsButton.UseVisualStyleBackColor = true;
            // 
            // artistAcceptedCommissionsList
            // 
            artistAcceptedCommissionsList.AutoScroll = true;
            artistAcceptedCommissionsList.Dock = DockStyle.Fill;
            artistAcceptedCommissionsList.Location = new Point(3, 56);
            artistAcceptedCommissionsList.Margin = new Padding(3, 4, 3, 4);
            artistAcceptedCommissionsList.Name = "artistAcceptedCommissionsList";
            artistAcceptedCommissionsList.Size = new Size(886, 402);
            artistAcceptedCommissionsList.TabIndex = 12;
            // 
            // acceptedCommissionsLabel
            // 
            acceptedCommissionsLabel.BackColor = Color.FromArgb(224, 224, 224);
            acceptedCommissionsLabel.Dock = DockStyle.Top;
            acceptedCommissionsLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            acceptedCommissionsLabel.Location = new Point(3, 4);
            acceptedCommissionsLabel.Name = "acceptedCommissionsLabel";
            acceptedCommissionsLabel.Padding = new Padding(11, 13, 11, 13);
            acceptedCommissionsLabel.Size = new Size(886, 52);
            acceptedCommissionsLabel.TabIndex = 9;
            acceptedCommissionsLabel.Text = "Accepted Commissions";
            // 
            // publicQueue
            // 
            publicQueue.Controls.Add(reloadQueueButton);
            publicQueue.Controls.Add(adminViewQueueGrid);
            publicQueue.Controls.Add(label4);
            publicQueue.Location = new Point(4, 29);
            publicQueue.Margin = new Padding(3, 4, 3, 4);
            publicQueue.Name = "publicQueue";
            publicQueue.Size = new Size(892, 462);
            publicQueue.TabIndex = 7;
            publicQueue.Text = "Public Queue";
            publicQueue.UseVisualStyleBackColor = true;
            // 
            // reloadQueueButton
            // 
            reloadQueueButton.Location = new Point(688, 13);
            reloadQueueButton.Margin = new Padding(3, 4, 3, 4);
            reloadQueueButton.Name = "reloadQueueButton";
            reloadQueueButton.Size = new Size(184, 31);
            reloadQueueButton.TabIndex = 12;
            reloadQueueButton.Text = "Reload Queue";
            reloadQueueButton.UseVisualStyleBackColor = true;
            reloadQueueButton.Click += reloadQueueButton_Click;
            // 
            // adminViewQueueGrid
            // 
            adminViewQueueGrid.AllowUserToAddRows = false;
            adminViewQueueGrid.AllowUserToDeleteRows = false;
            adminViewQueueGrid.AllowUserToResizeColumns = false;
            adminViewQueueGrid.AllowUserToResizeRows = false;
            adminViewQueueGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            adminViewQueueGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adminViewQueueGrid.Dock = DockStyle.Fill;
            adminViewQueueGrid.Location = new Point(0, 52);
            adminViewQueueGrid.Margin = new Padding(3, 4, 3, 4);
            adminViewQueueGrid.Name = "adminViewQueueGrid";
            adminViewQueueGrid.ReadOnly = true;
            adminViewQueueGrid.RowHeadersWidth = 51;
            adminViewQueueGrid.Size = new Size(892, 410);
            adminViewQueueGrid.TabIndex = 11;
            adminViewQueueGrid.CellFormatting += AdminViewQueueGrid_CellFormatting;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(224, 224, 224);
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(11, 13, 11, 13);
            label4.Size = new Size(892, 52);
            label4.TabIndex = 10;
            label4.Text = "Accepted Commissions";
            // 
            // conversationTab
            // 
            conversationTab.Location = new Point(4, 29);
            conversationTab.Margin = new Padding(3, 4, 3, 4);
            conversationTab.Name = "conversationTab";
            conversationTab.Size = new Size(892, 462);
            conversationTab.TabIndex = 8;
            conversationTab.Text = "Conversation";
            conversationTab.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Image = Properties.Resources.JellyPhlox;
            pictureBox2.Location = new Point(8, 8);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 65);
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
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(900, 73);
            label1.TabIndex = 3;
            label1.Text = "Commission @JellyPhlox";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // artistInformationTab
            // 
            artistInformationTab.Controls.Add(clientProfileTabs);
            artistInformationTab.Location = new Point(4, 29);
            artistInformationTab.Margin = new Padding(3, 4, 3, 4);
            artistInformationTab.Name = "artistInformationTab";
            artistInformationTab.Padding = new Padding(3, 4, 3, 4);
            artistInformationTab.Size = new Size(906, 576);
            artistInformationTab.TabIndex = 1;
            artistInformationTab.Text = "My Admin Information";
            artistInformationTab.UseVisualStyleBackColor = true;
            // 
            // clientProfileTabs
            // 
            clientProfileTabs.Controls.Add(userProfile);
            clientProfileTabs.Location = new Point(3, 8);
            clientProfileTabs.Margin = new Padding(3, 4, 3, 4);
            clientProfileTabs.Name = "clientProfileTabs";
            clientProfileTabs.SelectedIndex = 0;
            clientProfileTabs.Size = new Size(906, 623);
            clientProfileTabs.TabIndex = 0;
            // 
            // userProfile
            // 
            userProfile.Controls.Add(clientProfileLabel);
            userProfile.Controls.Add(labelUserProfile);
            userProfile.Location = new Point(4, 29);
            userProfile.Margin = new Padding(3, 4, 3, 4);
            userProfile.Name = "userProfile";
            userProfile.Padding = new Padding(3, 4, 3, 4);
            userProfile.Size = new Size(898, 590);
            userProfile.TabIndex = 1;
            userProfile.Text = "User Profile";
            userProfile.UseVisualStyleBackColor = true;
            // 
            // clientProfileLabel
            // 
            clientProfileLabel.AutoSize = true;
            clientProfileLabel.Location = new Point(13, 77);
            clientProfileLabel.Name = "clientProfileLabel";
            clientProfileLabel.Size = new Size(296, 120);
            clientProfileLabel.TabIndex = 10;
            clientProfileLabel.Text = "Username:\r\nPassword: *** (try change to however many)\r\n\r\nAssociated Emails:\r\n\r\n[Reset password]\r\n";
            // 
            // labelUserProfile
            // 
            labelUserProfile.BackColor = Color.FromArgb(224, 224, 224);
            labelUserProfile.Dock = DockStyle.Top;
            labelUserProfile.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserProfile.Location = new Point(3, 4);
            labelUserProfile.Name = "labelUserProfile";
            labelUserProfile.Padding = new Padding(11, 13, 11, 13);
            labelUserProfile.Size = new Size(892, 52);
            labelUserProfile.TabIndex = 9;
            labelUserProfile.Text = "User Profile";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // AdminDashboard
            // 
            ClientSize = new Size(914, 609);
            Controls.Add(adminTabs);
            Name = "AdminDashboard";
            Text = "Admin Dashboard";
            Load += AdminDashboard_Load;
            Shown += AdminDashboard_Shown;
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            adminTabs.ResumeLayout(false);
            workspaceTab.ResumeLayout(false);
            ArtistCommissionsDashboard.ResumeLayout(false);
            commissionOverview.ResumeLayout(false);
            artistAdminViewCommissionsList.ResumeLayout(false);
            // splitContainer2 removed; dynamic sections will be created at runtime
            acceptedCommissions.ResumeLayout(false);
            publicQueue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)adminViewQueueGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            artistInformationTab.ResumeLayout(false);
            clientProfileTabs.ResumeLayout(false);
            userProfile.ResumeLayout(false);
            userProfile.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private Label label12;
        private Label labelStatus;
        private TabControl adminTabs;
        private TabPage workspaceTab;
        private PictureBox pictureBox2;
        private Label label1;
        private TabPage artistInformationTab;
        private TabControl clientProfileTabs;
        private TabPage userProfile;
        private Label clientProfileLabel;
        private Label labelUserProfile;
        private TabControl ArtistCommissionsDashboard;
        private TabPage commissionOverview;
        private FlowLayoutPanel artistAdminViewCommissionsList;
        // splitContainer2, label2, label3 removed; commission overview uses dynamic controls at runtime
        private Button reloadCommOverviewButton;
        private Label commissionOverviewLabel;
        private TabPage acceptedCommissions;
        private Button reloadAcceptedCommsButton;
        private FlowLayoutPanel artistAcceptedCommissionsList;
        private Label acceptedCommissionsLabel;
        private TabPage publicQueue;
        private Button reloadQueueButton;
        private DataGridView adminViewQueueGrid;
        private Label label4;
        private TabPage conversationTab;
        private ContextMenuStrip contextMenuStrip1;
    }
}
