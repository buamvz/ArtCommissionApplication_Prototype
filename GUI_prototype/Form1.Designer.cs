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
            labelArtistEmail = new Label();
            labelArtistName = new Label();
            Info_ProfilePicture = new PictureBox();
            label4 = new Label();
            labelArtistBio = new Label();
            tabTOS = new TabPage();
            labelWontDraw = new Label();
            labelTerms = new Label();
            label2 = new Label();
            labelWillDraw = new Label();
            tabSamples = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            label8 = new Label();
            tabQueue = new TabPage();
            reloadButton = new Button();
            publicQueueGrid = new DataGridView();
            label11 = new Label();
            pictureBox2 = new PictureBox();
            clientTabs = new TabControl();
            artistPagesTab = new TabPage();
            pictureBox3 = new PictureBox();
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
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            tabQueue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)publicQueueGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            clientTabs.SuspendLayout();
            artistPagesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            label1.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkMagenta;
            label1.Location = new Point(3, 83);
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
            tabAll.Location = new Point(3, 138);
            tabAll.Name = "tabAll";
            tabAll.SelectedIndex = 0;
            tabAll.Size = new Size(786, 328);
            tabAll.TabIndex = 3;
            tabAll.SelectedIndexChanged += tabAll_SelectedIndexChanged;
            // 
            // tabHome
            // 
            tabHome.Controls.Add(label9);
            tabHome.Controls.Add(RequestComm);
            tabHome.Controls.Add(HomeParagraph);
            tabHome.Location = new Point(4, 22);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(3);
            tabHome.Size = new Size(778, 302);
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
            RequestComm.Location = new Point(8, 190);
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
            tabInformation.Controls.Add(labelArtistEmail);
            tabInformation.Controls.Add(labelArtistName);
            tabInformation.Controls.Add(Info_ProfilePicture);
            tabInformation.Controls.Add(label4);
            tabInformation.Controls.Add(labelArtistBio);
            tabInformation.Location = new Point(4, 22);
            tabInformation.Name = "tabInformation";
            tabInformation.Padding = new Padding(3);
            tabInformation.Size = new Size(778, 302);
            tabInformation.TabIndex = 1;
            tabInformation.Text = "About JellyPhlox";
            tabInformation.UseVisualStyleBackColor = true;
            // 
            // labelArtistEmail
            // 
            labelArtistEmail.BackColor = Color.WhiteSmoke;
            labelArtistEmail.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelArtistEmail.Location = new Point(6, 85);
            labelArtistEmail.Name = "labelArtistEmail";
            labelArtistEmail.Padding = new Padding(5);
            labelArtistEmail.Size = new Size(653, 34);
            labelArtistEmail.TabIndex = 9;
            labelArtistEmail.Text = "Email: JellyPhlox@gmail.com";
            // 
            // labelArtistName
            // 
            labelArtistName.BackColor = Color.WhiteSmoke;
            labelArtistName.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelArtistName.Location = new Point(6, 45);
            labelArtistName.Name = "labelArtistName";
            labelArtistName.Padding = new Padding(10);
            labelArtistName.Size = new Size(653, 40);
            labelArtistName.TabIndex = 8;
            labelArtistName.Text = "JellyPhlox";
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
            // labelArtistBio
            // 
            labelArtistBio.BackColor = Color.WhiteSmoke;
            labelArtistBio.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelArtistBio.Location = new Point(6, 132);
            labelArtistBio.Name = "labelArtistBio";
            labelArtistBio.Padding = new Padding(10);
            labelArtistBio.Size = new Size(653, 179);
            labelArtistBio.TabIndex = 3;
            labelArtistBio.Text = resources.GetString("labelArtistBio.Text");
            // 
            // tabTOS
            // 
            tabTOS.Controls.Add(labelWontDraw);
            tabTOS.Controls.Add(labelTerms);
            tabTOS.Controls.Add(label2);
            tabTOS.Controls.Add(labelWillDraw);
            tabTOS.Location = new Point(4, 22);
            tabTOS.Name = "tabTOS";
            tabTOS.Padding = new Padding(3);
            tabTOS.Size = new Size(778, 302);
            tabTOS.TabIndex = 2;
            tabTOS.Text = "Terms Of Service";
            tabTOS.UseVisualStyleBackColor = true;
            // 
            // labelWontDraw
            // 
            labelWontDraw.BackColor = Color.WhiteSmoke;
            labelWontDraw.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWontDraw.Location = new Point(627, 53);
            labelWontDraw.Name = "labelWontDraw";
            labelWontDraw.Padding = new Padding(10);
            labelWontDraw.Size = new Size(145, 307);
            labelWontDraw.TabIndex = 12;
            labelWontDraw.Text = "Will Draw\r\n\r\nWon't Draw\r\n";
            // 
            // labelTerms
            // 
            labelTerms.BackColor = Color.WhiteSmoke;
            labelTerms.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTerms.Location = new Point(8, 53);
            labelTerms.Name = "labelTerms";
            labelTerms.Padding = new Padding(10);
            labelTerms.Size = new Size(473, 246);
            labelTerms.TabIndex = 11;
            labelTerms.Text = "TOS introduction\r\n";
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
            // labelWillDraw
            // 
            labelWillDraw.BackColor = Color.WhiteSmoke;
            labelWillDraw.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWillDraw.Location = new Point(487, 53);
            labelWillDraw.Name = "labelWillDraw";
            labelWillDraw.Padding = new Padding(10);
            labelWillDraw.Size = new Size(134, 307);
            labelWillDraw.TabIndex = 9;
            labelWillDraw.Text = "Will Draw\r\n\r\nWon't Draw\r\n";
            // 
            // tabSamples
            // 
            tabSamples.AutoScroll = true;
            tabSamples.Controls.Add(flowLayoutPanel1);
            tabSamples.Controls.Add(label8);
            tabSamples.Location = new Point(4, 22);
            tabSamples.Name = "tabSamples";
            tabSamples.Padding = new Padding(3);
            tabSamples.Size = new Size(778, 302);
            tabSamples.TabIndex = 3;
            tabSamples.Text = "Samples Of Work";
            tabSamples.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(pictureBox4);
            flowLayoutPanel1.Controls.Add(pictureBox5);
            flowLayoutPanel1.Controls.Add(pictureBox8);
            flowLayoutPanel1.Controls.Add(pictureBox6);
            flowLayoutPanel1.Controls.Add(pictureBox7);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 42);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(772, 257);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dottore;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 239);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.paradise;
            pictureBox4.Location = new Point(198, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(197, 239);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.kpopdh_zine;
            pictureBox5.Location = new Point(401, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(342, 239);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
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
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.corazon_zine;
            pictureBox6.Location = new Point(322, 248);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(187, 263);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.artfight;
            pictureBox7.Location = new Point(515, 248);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(226, 259);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 4;
            pictureBox7.TabStop = false;
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
            // tabQueue
            // 
            tabQueue.Controls.Add(reloadButton);
            tabQueue.Controls.Add(publicQueueGrid);
            tabQueue.Controls.Add(label11);
            tabQueue.Location = new Point(4, 22);
            tabQueue.Name = "tabQueue";
            tabQueue.Padding = new Padding(3);
            tabQueue.Size = new Size(778, 302);
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
            publicQueueGrid.Size = new Size(772, 257);
            publicQueueGrid.TabIndex = 8;
            publicQueueGrid.CellFormatting += PublicQueueGrid_CellFormatting;
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
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(786, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
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
            clientTabs.SelectedIndexChanged += clientTabs_SelectedIndexChanged;
            // 
            // artistPagesTab
            // 
            artistPagesTab.Controls.Add(pictureBox3);
            artistPagesTab.Controls.Add(tabAll);
            artistPagesTab.Controls.Add(label1);
            artistPagesTab.Controls.Add(pictureBox2);
            artistPagesTab.Location = new Point(4, 24);
            artistPagesTab.Name = "artistPagesTab";
            artistPagesTab.Padding = new Padding(3);
            artistPagesTab.Size = new Size(792, 469);
            artistPagesTab.TabIndex = 0;
            artistPagesTab.Text = "JellyPhlox";
            artistPagesTab.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.JellyPhlox;
            pictureBox3.Location = new Point(731, 86);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
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
            AutoSize = true;
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
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            tabQueue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)publicQueueGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            clientTabs.ResumeLayout(false);
            artistPagesTab.ResumeLayout(false);
            artistPagesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Label labelArtistBio;
        private Label label11;
        private PictureBox Info_ProfilePicture;
        private PictureBox pictureBox2;
        private Label labelTerms;
        private Label label2;
        private Label labelWillDraw;
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
        private Label labelArtistName;
        private Label labelArtistEmail;
        private Label labelWontDraw;
        private PictureBox pictureBox3;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
    }
}
