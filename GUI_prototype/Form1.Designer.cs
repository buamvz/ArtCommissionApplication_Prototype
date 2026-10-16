namespace GUI_prototype
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            tabAll = new TabControl();
            tabHome = new TabPage();
            label9 = new Label();
            RequestComm = new Button();
            HomeParagraph = new Label();
            tabInformation = new TabPage();
            Info_ProfilePicture = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            tabTOS = new TabPage();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            label5 = new Label();
            tabSamples = new TabPage();
            label8 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            tabQueue = new TabPage();
            reloadButton = new Button();
            publicQueueGrid = new DataGridView();
            label11 = new Label();
            pictureBox2 = new PictureBox();
            clientTabs = new TabControl();
            artistPagesTab = new TabPage();
            clientPagesTab = new TabPage();
            clientProfileTabs = new TabControl();
            userMyCommissionsView = new TabPage();
            userMyCommissionsList = new FlowLayoutPanel();
            splitContainer1 = new SplitContainer();
            label14 = new Label();
            label15 = new Label();
            reloadCommissionsButton = new Button();
            labelMyComms = new Label();
            userProfile = new TabPage();
            clientProfileLabel = new Label();
            labelUserProfile = new Label();
            tabAll.SuspendLayout();
            tabHome.SuspendLayout();
            tabInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Info_ProfilePicture).BeginInit();
            tabTOS.SuspendLayout();
            tabSamples.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabQueue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)publicQueueGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            clientTabs.SuspendLayout();
            artistPagesTab.SuspendLayout();
            clientPagesTab.SuspendLayout();
            clientProfileTabs.SuspendLayout();
            userMyCommissionsView.SuspendLayout();
            userMyCommissionsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            userProfile.SuspendLayout();
            SuspendLayout();
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
            // tabAll
            // 
            tabAll.Controls.Add(tabHome);
            tabAll.Controls.Add(tabInformation);
            tabAll.Controls.Add(tabTOS);
            tabAll.Controls.Add(tabSamples);
            tabAll.Controls.Add(tabQueue);
            tabAll.Dock = DockStyle.Fill;
            tabAll.Font = new Font("Segoe UI", 8F);
            tabAll.Location = new Point(3, 58);
            tabAll.Name = "tabAll";
            tabAll.SelectedIndex = 0;
            tabAll.Size = new Size(786, 408);
            tabAll.TabIndex = 3;
            // 
            // tabHome
            // 
            tabHome.Controls.Add(label9);
            tabHome.Controls.Add(RequestComm);
            tabHome.Controls.Add(HomeParagraph);
            tabHome.Location = new Point(4, 22);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(3);
            tabHome.Size = new Size(778, 382);
            tabHome.TabIndex = 0;
            tabHome.Text = "Home";
            tabHome.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(224, 224, 224);
            label9.Dock = DockStyle.Top;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 3);
            label9.Name = "label9";
            label9.Padding = new Padding(10);
            label9.Size = new Size(772, 39);
            label9.TabIndex = 5;
            label9.Text = "Commission Request";
            // 
            // RequestComm
            // 
            RequestComm.AccessibleName = "RequestComm";
            RequestComm.BackColor = Color.LavenderBlush;
            RequestComm.Font = new Font("Candara", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RequestComm.ForeColor = Color.Purple;
            RequestComm.Location = new Point(8, 252);
            RequestComm.Name = "RequestComm";
            RequestComm.Size = new Size(252, 106);
            RequestComm.TabIndex = 0;
            RequestComm.Text = "Request Commission Form";
            RequestComm.UseVisualStyleBackColor = false;
            RequestComm.Click += RequestComm_Click;
            // 
            // HomeParagraph
            // 
            HomeParagraph.BackColor = Color.WhiteSmoke;
            HomeParagraph.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HomeParagraph.Location = new Point(8, 53);
            HomeParagraph.Name = "HomeParagraph";
            HomeParagraph.Padding = new Padding(10);
            HomeParagraph.Size = new Size(760, 138);
            HomeParagraph.TabIndex = 2;
            HomeParagraph.Text = resources.GetString("HomeParagraph.Text");
            // 
            // tabInformation
            // 
            tabInformation.Controls.Add(Info_ProfilePicture);
            tabInformation.Controls.Add(label4);
            tabInformation.Controls.Add(label3);
            tabInformation.Location = new Point(4, 22);
            tabInformation.Name = "tabInformation";
            tabInformation.Padding = new Padding(3);
            tabInformation.Size = new Size(778, 382);
            tabInformation.TabIndex = 1;
            tabInformation.Text = "About JellyPhlox";
            tabInformation.UseVisualStyleBackColor = true;
            // 
            // Info_ProfilePicture
            // 
            Info_ProfilePicture.BackgroundImage = (Image)resources.GetObject("Info_ProfilePicture.BackgroundImage");
            Info_ProfilePicture.Image = Properties.Resources.JellyPhlox;
            Info_ProfilePicture.Location = new Point(659, 45);
            Info_ProfilePicture.Name = "Info_ProfilePicture";
            Info_ProfilePicture.Size = new Size(110, 109);
            Info_ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            Info_ProfilePicture.TabIndex = 7;
            Info_ProfilePicture.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(224, 224, 224);
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Padding = new Padding(10);
            label4.Size = new Size(772, 39);
            label4.TabIndex = 4;
            label4.Text = "About the Artist";
            // 
            // label3
            // 
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 42);
            label3.Name = "label3";
            label3.Padding = new Padding(10);
            label3.Size = new Size(653, 179);
            label3.TabIndex = 3;
            label3.Text = resources.GetString("label3.Text");
            // 
            // tabTOS
            // 
            tabTOS.Controls.Add(label7);
            tabTOS.Controls.Add(label6);
            tabTOS.Controls.Add(label2);
            tabTOS.Controls.Add(label5);
            tabTOS.Location = new Point(4, 22);
            tabTOS.Name = "tabTOS";
            tabTOS.Padding = new Padding(3);
            tabTOS.Size = new Size(778, 382);
            tabTOS.TabIndex = 2;
            tabTOS.Text = "Terms Of Service";
            tabTOS.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.BackColor = Color.WhiteSmoke;
            label7.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(8, 138);
            label7.Name = "label7";
            label7.Padding = new Padding(10);
            label7.Size = new Size(473, 85);
            label7.TabIndex = 12;
            label7.Text = "TOS paragraph\r\n";
            // 
            // label6
            // 
            label6.BackColor = Color.WhiteSmoke;
            label6.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 53);
            label6.Name = "label6";
            label6.Padding = new Padding(10);
            label6.Size = new Size(473, 85);
            label6.TabIndex = 11;
            label6.Text = "TOS introduction\r\n";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Padding = new Padding(10);
            label2.Size = new Size(772, 39);
            label2.TabIndex = 10;
            label2.Text = "Terms Of Service";
            // 
            // label5
            // 
            label5.BackColor = Color.WhiteSmoke;
            label5.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(487, 53);
            label5.Name = "label5";
            label5.Padding = new Padding(10);
            label5.Size = new Size(297, 307);
            label5.TabIndex = 9;
            label5.Text = "Will Draw\r\n\r\nWon't Draw\r\n";
            // 
            // tabSamples
            // 
            tabSamples.Controls.Add(label8);
            tabSamples.Controls.Add(label10);
            tabSamples.Controls.Add(pictureBox1);
            tabSamples.Location = new Point(4, 22);
            tabSamples.Name = "tabSamples";
            tabSamples.Padding = new Padding(3);
            tabSamples.Size = new Size(778, 382);
            tabSamples.TabIndex = 3;
            tabSamples.Text = "Samples Of Work";
            tabSamples.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(224, 224, 224);
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 3);
            label8.Name = "label8";
            label8.Padding = new Padding(10);
            label8.Size = new Size(772, 39);
            label8.TabIndex = 11;
            label8.Text = "Samples of Work";
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 12F);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(211, 56);
            label10.Name = "label10";
            label10.Padding = new Padding(10);
            label10.Size = new Size(247, 140);
            label10.TabIndex = 8;
            label10.Text = "Note: samples will be listed in date order with short labels if needed - or tool tips?";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.Untitled;
            pictureBox1.Location = new Point(8, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 203);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // tabQueue
            // 
            tabQueue.Controls.Add(reloadButton);
            tabQueue.Controls.Add(publicQueueGrid);
            tabQueue.Controls.Add(label11);
            tabQueue.Location = new Point(4, 22);
            tabQueue.Name = "tabQueue";
            tabQueue.Padding = new Padding(3);
            tabQueue.Size = new Size(778, 382);
            tabQueue.TabIndex = 4;
            tabQueue.Text = "Public Queue";
            tabQueue.UseVisualStyleBackColor = true;
            // 
            // reloadButton
            // 
            reloadButton.Location = new Point(642, 11);
            reloadButton.Name = "reloadButton";
            reloadButton.Size = new Size(125, 23);
            reloadButton.TabIndex = 9;
            reloadButton.Text = "Reload Queue";
            reloadButton.UseVisualStyleBackColor = true;
            reloadButton.Click += reloadButton_Click;
            // 
            // publicQueueGrid
            // 
            publicQueueGrid.AllowUserToAddRows = false;
            publicQueueGrid.AllowUserToDeleteRows = false;
            publicQueueGrid.AllowUserToResizeColumns = false;
            publicQueueGrid.AllowUserToResizeRows = false;
            publicQueueGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            publicQueueGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            publicQueueGrid.Dock = DockStyle.Fill;
            publicQueueGrid.Location = new Point(3, 42);
            publicQueueGrid.Name = "publicQueueGrid";
            publicQueueGrid.ReadOnly = true;
            publicQueueGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            publicQueueGrid.Size = new Size(772, 337);
            publicQueueGrid.TabIndex = 8;
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(224, 224, 224);
            label11.Dock = DockStyle.Top;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 3);
            label11.Name = "label11";
            label11.Padding = new Padding(10);
            label11.Size = new Size(772, 39);
            label11.TabIndex = 7;
            label11.Text = "Public Queue\r\n";
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
            // clientTabs
            // 
            clientTabs.Controls.Add(artistPagesTab);
            clientTabs.Controls.Add(clientPagesTab);
            clientTabs.Location = new Point(0, 0);
            clientTabs.Name = "clientTabs";
            clientTabs.SelectedIndex = 0;
            clientTabs.Size = new Size(800, 497);
            clientTabs.SizeMode = TabSizeMode.Fixed;
            clientTabs.TabIndex = 9;
            // 
            // artistPagesTab
            // 
            artistPagesTab.Controls.Add(pictureBox2);
            artistPagesTab.Controls.Add(tabAll);
            artistPagesTab.Controls.Add(label1);
            artistPagesTab.Location = new Point(4, 24);
            artistPagesTab.Name = "artistPagesTab";
            artistPagesTab.Padding = new Padding(3);
            artistPagesTab.Size = new Size(792, 469);
            artistPagesTab.TabIndex = 0;
            artistPagesTab.Text = "JellyPhlox";
            artistPagesTab.UseVisualStyleBackColor = true;
            // 
            // clientPagesTab
            // 
            clientPagesTab.Controls.Add(clientProfileTabs);
            clientPagesTab.Location = new Point(4, 24);
            clientPagesTab.Name = "clientPagesTab";
            clientPagesTab.Padding = new Padding(3);
            clientPagesTab.Size = new Size(792, 469);
            clientPagesTab.TabIndex = 1;
            clientPagesTab.Text = "My Profile";
            clientPagesTab.UseVisualStyleBackColor = true;
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
            clientProfileTabs.SelectedIndexChanged += clientProfileTabs_SelectedIndexChanged;
            // 
            // userMyCommissionsView
            // 
            userMyCommissionsView.Controls.Add(userMyCommissionsList);
            userMyCommissionsView.Controls.Add(reloadCommissionsButton);
            userMyCommissionsView.Controls.Add(labelMyComms);
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
            userMyCommissionsList.Controls.Add(splitContainer1);
            userMyCommissionsList.Dock = DockStyle.Fill;
            userMyCommissionsList.Location = new Point(3, 42);
            userMyCommissionsList.Name = "userMyCommissionsList";
            userMyCommissionsList.Size = new Size(779, 394);
            userMyCommissionsList.TabIndex = 11;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AutoScroll = true;
            splitContainer1.Panel1.BackColor = Color.Gainsboro;
            splitContainer1.Panel1.Controls.Add(label14);
            splitContainer1.Panel1.Controls.Add(label15);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.WhiteSmoke;
            splitContainer1.Size = new Size(776, 130);
            splitContainer1.SplitterDistance = 353;
            splitContainer1.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F);
            label14.Location = new Point(5, 34);
            label14.Name = "label14";
            label14.Size = new Size(132, 133);
            label14.TabIndex = 1;
            label14.Text = "Name:\r\nEmail:\r\nCommission Details:\r\n\r\nDescription:\r\n\r\nThank you!";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label15.Location = new Point(5, 12);
            label15.Name = "label15";
            label15.Size = new Size(112, 19);
            label15.TabIndex = 0;
            label15.Text = "Status: Pending";
            // 
            // reloadCommissionsButton
            // 
            reloadCommissionsButton.Location = new Point(547, 6);
            reloadCommissionsButton.Name = "reloadCommissionsButton";
            reloadCommissionsButton.Size = new Size(230, 23);
            reloadCommissionsButton.TabIndex = 10;
            reloadCommissionsButton.Text = "Reload My Commissions";
            reloadCommissionsButton.UseVisualStyleBackColor = true;
            reloadCommissionsButton.Click += reloadCommissionsButton_Click_1;
            // 
            // labelMyComms
            // 
            labelMyComms.BackColor = Color.FromArgb(224, 224, 224);
            labelMyComms.Dock = DockStyle.Top;
            labelMyComms.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMyComms.Location = new Point(3, 3);
            labelMyComms.Name = "labelMyComms";
            labelMyComms.Padding = new Padding(10);
            labelMyComms.Size = new Size(779, 39);
            labelMyComms.TabIndex = 8;
            labelMyComms.Text = "My Commissions";
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
            clientProfileLabel.Location = new Point(6, 52);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
            Controls.Add(clientTabs);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabAll.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            tabInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Info_ProfilePicture).EndInit();
            tabTOS.ResumeLayout(false);
            tabSamples.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabQueue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)publicQueueGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            clientTabs.ResumeLayout(false);
            artistPagesTab.ResumeLayout(false);
            clientPagesTab.ResumeLayout(false);
            clientProfileTabs.ResumeLayout(false);
            userMyCommissionsView.ResumeLayout(false);
            userMyCommissionsList.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            userProfile.ResumeLayout(false);
            userProfile.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TabControl tabAll;
        private TabPage tabHome;
        private Button RequestComm;
        private Label HomeParagraph;
        private TabPage tabInformation;
        private TabPage tabTOS;
        private TabPage tabSamples;
        private TabPage tabQueue;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label10;
        private Label label11;
        private PictureBox Info_ProfilePicture;
        private PictureBox pictureBox2;
        private Label label7;
        private Label label6;
        private Label label2;
        private Label label5;
        private Label label8;
        private Label label9;
        private DataGridView publicQueueGrid;
        private Button reloadButton;
        private TabControl clientTabs;
        private TabPage clientPagesTab;
        private TabPage artistPagesTab;
        private TabControl clientProfileTabs;
        private TabPage userProfile;
        private TabPage userMyCommissionsView;
        private Button reloadCommissionsButton;
        private Label labelMyComms;
        private SplitContainer splitContainer1;
        private Label label14;
        private Label label15;
        private Panel panel1;
        private Label clientProfileLabel;
        private Label labelUserProfile;
        private FlowLayoutPanel userMyCommissionsList;
    }
}
