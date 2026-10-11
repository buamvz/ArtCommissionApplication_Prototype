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
            headerLabel = new Label();
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
            tabMyCommissions_Client = new TabPage();
            myCommissionsView = new FlowLayoutPanel();
            labelMyComms = new Label();
            splitContainer1 = new SplitContainer();
            label12 = new Label();
            labelStatus = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            tabAll.SuspendLayout();
            tabHome.SuspendLayout();
            tabInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Info_ProfilePicture).BeginInit();
            tabTOS.SuspendLayout();
            tabSamples.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabQueue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)publicQueueGrid).BeginInit();
            tabMyCommissions_Client.SuspendLayout();
            myCommissionsView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Location = new Point(12, 82);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(130, 20);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Admin Dashboard";
            // 
            // tabAll
            // 
            tabAll.Controls.Add(tabHome);
            tabAll.Controls.Add(tabInformation);
            tabAll.Controls.Add(tabTOS);
            tabAll.Controls.Add(tabSamples);
            tabAll.Controls.Add(tabQueue);
            tabAll.Controls.Add(tabMyCommissions_Client);
            tabAll.Font = new Font("Segoe UI", 8F);
            tabAll.Location = new Point(4, 110);
            tabAll.Margin = new Padding(3, 4, 3, 4);
            tabAll.Name = "tabAll";
            tabAll.SelectedIndex = 0;
            tabAll.Size = new Size(914, 466);
            tabAll.TabIndex = 4;
            // 
            // tabHome
            // 
            tabHome.Controls.Add(label9);
            tabHome.Controls.Add(RequestComm);
            tabHome.Controls.Add(HomeParagraph);
            tabHome.Location = new Point(4, 26);
            tabHome.Margin = new Padding(3, 4, 3, 4);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(3, 4, 3, 4);
            tabHome.Size = new Size(906, 436);
            tabHome.TabIndex = 0;
            tabHome.Text = "Home";
            tabHome.UseVisualStyleBackColor = true;
            tabHome.Click += tabHome_Click;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(224, 224, 224);
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(9, 19);
            label9.Name = "label9";
            label9.Padding = new Padding(11, 13, 11, 13);
            label9.Size = new Size(869, 52);
            label9.TabIndex = 5;
            label9.Text = "Commission Request";
            label9.Click += label9_Click;
            // 
            // RequestComm
            // 
            RequestComm.AccessibleName = "RequestComm";
            RequestComm.BackColor = Color.LavenderBlush;
            RequestComm.Font = new Font("Candara", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RequestComm.ForeColor = Color.Purple;
            RequestComm.Location = new Point(9, 336);
            RequestComm.Margin = new Padding(3, 4, 3, 4);
            RequestComm.Name = "RequestComm";
            RequestComm.Size = new Size(288, 141);
            RequestComm.TabIndex = 0;
            RequestComm.Text = "Request Commission Form";
            RequestComm.UseVisualStyleBackColor = false;
            // 
            // HomeParagraph
            // 
            HomeParagraph.BackColor = Color.WhiteSmoke;
            HomeParagraph.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HomeParagraph.Location = new Point(9, 71);
            HomeParagraph.Name = "HomeParagraph";
            HomeParagraph.Padding = new Padding(11, 13, 11, 13);
            HomeParagraph.Size = new Size(869, 184);
            HomeParagraph.TabIndex = 2;
            HomeParagraph.Text = resources.GetString("HomeParagraph.Text");
            // 
            // tabInformation
            // 
            tabInformation.Controls.Add(Info_ProfilePicture);
            tabInformation.Controls.Add(label4);
            tabInformation.Controls.Add(label3);
            tabInformation.Location = new Point(4, 26);
            tabInformation.Margin = new Padding(3, 4, 3, 4);
            tabInformation.Name = "tabInformation";
            tabInformation.Padding = new Padding(3, 4, 3, 4);
            tabInformation.Size = new Size(906, 436);
            tabInformation.TabIndex = 1;
            tabInformation.Text = "About JellyPhlox";
            tabInformation.UseVisualStyleBackColor = true;
            // 
            // Info_ProfilePicture
            // 
            Info_ProfilePicture.BackgroundImage = (Image)resources.GetObject("Info_ProfilePicture.BackgroundImage");
            Info_ProfilePicture.Image = Properties.Resources.JellyPhlox;
            Info_ProfilePicture.Location = new Point(762, 19);
            Info_ProfilePicture.Name = "Info_ProfilePicture";
            Info_ProfilePicture.Size = new Size(106, 101);
            Info_ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            Info_ProfilePicture.TabIndex = 2;
            Info_ProfilePicture.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.WhiteSmoke;
            label4.Location = new Point(9, 19);
            label4.Name = "label4";
            label4.Padding = new Padding(11, 13, 11, 13);
            label4.Size = new Size(747, 337);
            label4.TabIndex = 1;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(9, 12);
            label3.Name = "label3";
            label3.Size = new Size(178, 23);
            label3.TabIndex = 0;
            label3.Text = "About JellyPhlox (info)";
            // 
            // tabTOS
            // 
            tabTOS.Controls.Add(label7);
            tabTOS.Controls.Add(label6);
            tabTOS.Controls.Add(label2);
            tabTOS.Controls.Add(label5);
            tabTOS.Location = new Point(4, 26);
            tabTOS.Margin = new Padding(3, 4, 3, 4);
            tabTOS.Name = "tabTOS";
            tabTOS.Padding = new Padding(3, 4, 3, 4);
            tabTOS.Size = new Size(906, 436);
            tabTOS.TabIndex = 2;
            tabTOS.Text = "Terms";
            tabTOS.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 60);
            label7.Name = "label7";
            label7.Size = new Size(311, 20);
            label7.TabIndex = 3;
            label7.Text = "These are the terms. Use the UI to accept them.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(9, 12);
            label6.Name = "label6";
            label6.Size = new Size(166, 23);
            label6.TabIndex = 2;
            label6.Text = "Terms of Service";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 36);
            label2.Name = "label2";
            label2.Size = new Size(179, 20);
            label2.TabIndex = 1;
            label2.Text = "Please read these terms...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 88);
            label5.Name = "label5";
            label5.Size = new Size(342, 20);
            label5.TabIndex = 0;
            label5.Text = "By using this service you agree to the following...";
            // 
            // tabSamples
            // 
            tabSamples.Controls.Add(label8);
            tabSamples.Controls.Add(label10);
            tabSamples.Controls.Add(pictureBox1);
            tabSamples.Location = new Point(4, 26);
            tabSamples.Margin = new Padding(3, 4, 3, 4);
            tabSamples.Name = "tabSamples";
            tabSamples.Padding = new Padding(3, 4, 3, 4);
            tabSamples.Size = new Size(906, 436);
            tabSamples.TabIndex = 3;
            tabSamples.Text = "Samples";
            tabSamples.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.Location = new Point(9, 12);
            label8.Name = "label8";
            label8.Size = new Size(78, 23);
            label8.TabIndex = 2;
            label8.Text = "Samples";
            // 
            // label10
            // 
            label10.Location = new Point(9, 36);
            label10.Name = "label10";
            label10.Size = new Size(600, 300);
            label10.TabIndex = 1;
            label10.Text = "Sample art will appear here.";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(620, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 184);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabQueue
            // 
            tabQueue.Controls.Add(reloadButton);
            tabQueue.Controls.Add(publicQueueGrid);
            tabQueue.Controls.Add(label11);
            tabQueue.Location = new Point(4, 26);
            tabQueue.Margin = new Padding(3, 4, 3, 4);
            tabQueue.Name = "tabQueue";
            tabQueue.Padding = new Padding(3, 4, 3, 4);
            tabQueue.Size = new Size(906, 436);
            tabQueue.TabIndex = 4;
            tabQueue.Text = "Queue";
            tabQueue.UseVisualStyleBackColor = true;
            // 
            // reloadButton
            // 
            reloadButton.Location = new Point(9, 384);
            reloadButton.Name = "reloadButton";
            reloadButton.Size = new Size(94, 29);
            reloadButton.TabIndex = 2;
            reloadButton.Text = "Reload";
            reloadButton.UseVisualStyleBackColor = true;
            // 
            // publicQueueGrid
            // 
            publicQueueGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            publicQueueGrid.Location = new Point(9, 49);
            publicQueueGrid.Name = "publicQueueGrid";
            publicQueueGrid.RowHeadersWidth = 51;
            publicQueueGrid.RowTemplate.Height = 29;
            publicQueueGrid.Size = new Size(869, 318);
            publicQueueGrid.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label11.Location = new Point(9, 12);
            label11.Name = "label11";
            label11.Size = new Size(59, 23);
            label11.TabIndex = 0;
            label11.Text = "Queue";
            // 
            // tabMyCommissions_Client
            // 
            tabMyCommissions_Client.Controls.Add(myCommissionsView);
            tabMyCommissions_Client.Location = new Point(4, 26);
            tabMyCommissions_Client.Margin = new Padding(3, 4, 3, 4);
            tabMyCommissions_Client.Name = "tabMyCommissions_Client";
            tabMyCommissions_Client.Padding = new Padding(3, 4, 3, 4);
            tabMyCommissions_Client.Size = new Size(906, 436);
            tabMyCommissions_Client.TabIndex = 5;
            tabMyCommissions_Client.Text = "My Commissions";
            tabMyCommissions_Client.UseVisualStyleBackColor = true;
            // 
            // myCommissionsView
            // 
            myCommissionsView.Controls.Add(labelMyComms);
            myCommissionsView.Location = new Point(9, 9);
            myCommissionsView.Name = "myCommissionsView";
            myCommissionsView.Size = new Size(869, 418);
            myCommissionsView.TabIndex = 0;
            // 
            // labelMyComms
            // 
            labelMyComms.AutoSize = true;
            labelMyComms.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelMyComms.Location = new Point(3, 0);
            labelMyComms.Name = "labelMyComms";
            labelMyComms.Size = new Size(130, 23);
            labelMyComms.TabIndex = 0;
            labelMyComms.Text = "My Commissions";
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
            // label1
            // 
            label1.BackColor = Color.LavenderBlush;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkMagenta;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(914, 73);
            label1.TabIndex = 5;
            label1.Text = "Commission @JellyPhlox";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Image = Properties.Resources.JellyPhlox;
            pictureBox2.Location = new Point(5, 5);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // AdminDashboard
            // 
            ClientSize = new Size(914, 609);
            Controls.Add(pictureBox2);
            Controls.Add(tabAll);
            Controls.Add(label1);
            Controls.Add(headerLabel);
            Name = "AdminDashboard";
            Text = "Admin Dashboard";
            Load += AdminDashboard_Load;
            tabAll.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            tabInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Info_ProfilePicture).EndInit();
            tabTOS.ResumeLayout(false);
            tabSamples.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabQueue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)publicQueueGrid).EndInit();
            tabMyCommissions_Client.ResumeLayout(false);
            myCommissionsView.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TabControl tabAll;
        private TabPage tabHome;
        private Label label9;
        private Button RequestComm;
        private Label HomeParagraph;
        private TabPage tabInformation;
        private PictureBox Info_ProfilePicture;
        private Label label4;
        private Label label3;
        private TabPage tabTOS;
        private Label label7;
        private Label label6;
        private Label label2;
        private Label label5;
        private TabPage tabSamples;
        private Label label8;
        private Label label10;
        private PictureBox pictureBox1;
        private TabPage tabQueue;
        private Button reloadButton;
        private DataGridView publicQueueGrid;
        private Label label11;
        private TabPage tabMyCommissions_Client;
        private FlowLayoutPanel myCommissionsView;
        private Label labelMyComms;
        private SplitContainer splitContainer1;
        private Label label12;
        private Label labelStatus;
        private Label label1;
        private PictureBox pictureBox2;
    }
}
