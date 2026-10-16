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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            splitContainer1 = new SplitContainer();
            label12 = new Label();
            labelStatus = new Label();
            adminTabs = new TabControl();
            workspaceTab = new TabPage();
            artistAcceptedCommissionsList = new TabControl();
            incomingCommissions = new TabPage();
            artistPendingCommissionsList = new FlowLayoutPanel();
            splitContainer2 = new SplitContainer();
            label2 = new Label();
            label3 = new Label();
            reloadCommRequestsButton = new Button();
            incomingCommissionsLabel = new Label();
            publicQueue = new TabPage();
            conversationTab = new TabPage();
            activeCommissionsTab = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            reloadAcceptedCommsButton = new Button();
            acceptedCommissionsLabel = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            artistInformationTab = new TabPage();
            clientProfileTabs = new TabControl();
            userProfile = new TabPage();
            clientProfileLabel = new Label();
            labelUserProfile = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            adminTabs.SuspendLayout();
            workspaceTab.SuspendLayout();
            artistAcceptedCommissionsList.SuspendLayout();
            incomingCommissions.SuspendLayout();
            artistPendingCommissionsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.SuspendLayout();
            activeCommissionsTab.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
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
            label12.Size = new Size(163, 161);
            label12.TabIndex = 1;
            label12.Text = "Name:\r\nEmail:\r\nCommission Details:\r\n\r\nDescription:\r\n\r\nThank you!";
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
            workspaceTab.Controls.Add(artistAcceptedCommissionsList);
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
            // artistAcceptedCommissionsList
            // 
            artistAcceptedCommissionsList.Controls.Add(incomingCommissions);
            artistAcceptedCommissionsList.Controls.Add(publicQueue);
            artistAcceptedCommissionsList.Controls.Add(conversationTab);
            artistAcceptedCommissionsList.Controls.Add(activeCommissionsTab);
            artistAcceptedCommissionsList.Dock = DockStyle.Fill;
            artistAcceptedCommissionsList.Location = new Point(3, 77);
            artistAcceptedCommissionsList.Margin = new Padding(3, 4, 3, 4);
            artistAcceptedCommissionsList.Name = "artistAcceptedCommissionsList";
            artistAcceptedCommissionsList.SelectedIndex = 0;
            artistAcceptedCommissionsList.Size = new Size(900, 495);
            artistAcceptedCommissionsList.TabIndex = 9;
            // 
            // incomingCommissions
            // 
            incomingCommissions.Controls.Add(artistPendingCommissionsList);
            incomingCommissions.Controls.Add(reloadCommRequestsButton);
            incomingCommissions.Controls.Add(incomingCommissionsLabel);
            incomingCommissions.Location = new Point(4, 29);
            incomingCommissions.Margin = new Padding(3, 4, 3, 4);
            incomingCommissions.Name = "incomingCommissions";
            incomingCommissions.Padding = new Padding(3, 4, 3, 4);
            incomingCommissions.Size = new Size(892, 462);
            incomingCommissions.TabIndex = 6;
            incomingCommissions.Text = "Quality Dashboard";
            incomingCommissions.UseVisualStyleBackColor = true;
            // 
            // artistPendingCommissionsList
            // 
            artistPendingCommissionsList.Controls.Add(splitContainer2);
            artistPendingCommissionsList.Dock = DockStyle.Fill;
            artistPendingCommissionsList.Location = new Point(3, 56);
            artistPendingCommissionsList.Margin = new Padding(3, 4, 3, 4);
            artistPendingCommissionsList.Name = "artistPendingCommissionsList";
            artistPendingCommissionsList.Size = new Size(886, 402);
            artistPendingCommissionsList.TabIndex = 11;
            // 
            // splitContainer2
            // 
            splitContainer2.Location = new Point(3, 4);
            splitContainer2.Margin = new Padding(3, 4, 3, 4);
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
            splitContainer2.Size = new Size(887, 173);
            splitContainer2.SplitterDistance = 403;
            splitContainer2.SplitterWidth = 5;
            splitContainer2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(163, 161);
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
            label3.Size = new Size(135, 23);
            label3.TabIndex = 0;
            label3.Text = "Status: Pending";
            // 
            // reloadCommRequestsButton
            // 
            reloadCommRequestsButton.Location = new Point(600, 17);
            reloadCommRequestsButton.Margin = new Padding(3, 4, 3, 4);
            reloadCommRequestsButton.Name = "reloadCommRequestsButton";
            reloadCommRequestsButton.Size = new Size(263, 31);
            reloadCommRequestsButton.TabIndex = 10;
            reloadCommRequestsButton.Text = "Reload My Commissions";
            reloadCommRequestsButton.UseVisualStyleBackColor = true;
            // 
            // incomingCommissionsLabel
            // 
            incomingCommissionsLabel.BackColor = Color.FromArgb(224, 224, 224);
            incomingCommissionsLabel.Dock = DockStyle.Top;
            incomingCommissionsLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            incomingCommissionsLabel.Location = new Point(3, 4);
            incomingCommissionsLabel.Name = "incomingCommissionsLabel";
            incomingCommissionsLabel.Padding = new Padding(11, 13, 11, 13);
            incomingCommissionsLabel.Size = new Size(886, 52);
            incomingCommissionsLabel.TabIndex = 8;
            incomingCommissionsLabel.Text = "Pending Commissions";
            // 
            // publicQueue
            // 
            publicQueue.Location = new Point(4, 29);
            publicQueue.Margin = new Padding(3, 4, 3, 4);
            publicQueue.Name = "publicQueue";
            publicQueue.Size = new Size(892, 462);
            publicQueue.TabIndex = 7;
            publicQueue.Text = "Public Queue";
            publicQueue.UseVisualStyleBackColor = true;
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
            // activeCommissionsTab
            // 
            activeCommissionsTab.Controls.Add(flowLayoutPanel1);
            activeCommissionsTab.Location = new Point(4, 29);
            activeCommissionsTab.Name = "activeCommissionsTab";
            activeCommissionsTab.Padding = new Padding(3);
            activeCommissionsTab.Size = new Size(892, 462);
            activeCommissionsTab.TabIndex = 9;
            activeCommissionsTab.Text = "Active Commissions";
            activeCommissionsTab.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(reloadAcceptedCommsButton);
            flowLayoutPanel1.Controls.Add(acceptedCommissionsLabel);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(886, 456);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // reloadAcceptedCommsButton
            // 
            reloadAcceptedCommsButton.Location = new Point(3, 4);
            reloadAcceptedCommsButton.Margin = new Padding(3, 4, 3, 4);
            reloadAcceptedCommsButton.Name = "reloadAcceptedCommsButton";
            reloadAcceptedCommsButton.Size = new Size(263, 31);
            reloadAcceptedCommsButton.TabIndex = 11;
            reloadAcceptedCommsButton.Text = "Reload Artist Active Commissions";
            reloadAcceptedCommsButton.UseVisualStyleBackColor = true;
            // 
            // acceptedCommissionsLabel
            // 
            acceptedCommissionsLabel.BackColor = Color.FromArgb(224, 224, 224);
            acceptedCommissionsLabel.Dock = DockStyle.Top;
            acceptedCommissionsLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            acceptedCommissionsLabel.Location = new Point(3, 39);
            acceptedCommissionsLabel.Name = "acceptedCommissionsLabel";
            acceptedCommissionsLabel.Padding = new Padding(11, 13, 11, 13);
            acceptedCommissionsLabel.Size = new Size(882, 52);
            acceptedCommissionsLabel.TabIndex = 9;
            acceptedCommissionsLabel.Text = "Active Commissions";
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
            // AdminDashboard
            // 
            ClientSize = new Size(914, 609);
            Controls.Add(adminTabs);
            Name = "AdminDashboard";
            Text = "Admin Dashboard";
            Load += AdminDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            adminTabs.ResumeLayout(false);
            workspaceTab.ResumeLayout(false);
            artistAcceptedCommissionsList.ResumeLayout(false);
            incomingCommissions.ResumeLayout(false);
            artistPendingCommissionsList.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            activeCommissionsTab.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
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
        private TabControl artistAcceptedCommissionsList;
        private TabPage incomingCommissions;
        private FlowLayoutPanel artistPendingCommissionsList;
        private SplitContainer splitContainer2;
        private Label label2;
        private Label label3;
        private Button reloadCommRequestsButton;
        private Label incomingCommissionsLabel;
        private TabPage publicQueue;
        private TabPage conversationTab;
        private PictureBox pictureBox2;
        private Label label1;
        private TabPage artistInformationTab;
        private TabControl clientProfileTabs;
        private TabPage userProfile;
        private Label clientProfileLabel;
        private Label labelUserProfile;
        private TabPage activeCommissionsTab;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button reloadAcceptedCommsButton;
        private Label acceptedCommissionsLabel;
    }
}
