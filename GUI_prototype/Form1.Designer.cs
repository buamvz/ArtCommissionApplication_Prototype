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
            label1 = new Label();
            tabAll = new TabControl();
            tabHome = new TabPage();
            RequestComm = new Button();
            label2 = new Label();
            tabInformation = new TabPage();
            tabTOS = new TabPage();
            tabSamples = new TabPage();
            tabQueue = new TabPage();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label11 = new Label();
            tabAll.SuspendLayout();
            tabHome.SuspendLayout();
            tabInformation.SuspendLayout();
            tabTOS.SuspendLayout();
            tabSamples.SuspendLayout();
            tabQueue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("SWItal", 32.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 55);
            label1.TabIndex = 3;
            label1.Text = "Commission [Artist1]";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabAll
            // 
            tabAll.Controls.Add(tabHome);
            tabAll.Controls.Add(tabInformation);
            tabAll.Controls.Add(tabTOS);
            tabAll.Controls.Add(tabSamples);
            tabAll.Controls.Add(tabQueue);
            tabAll.Font = new Font("Segoe UI", 8F);
            tabAll.Location = new Point(0, 58);
            tabAll.Name = "tabAll";
            tabAll.SelectedIndex = 0;
            tabAll.Size = new Size(800, 392);
            tabAll.TabIndex = 3;
            // 
            // tabHome
            // 
            tabHome.Controls.Add(RequestComm);
            tabHome.Controls.Add(label2);
            tabHome.Location = new Point(4, 22);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(3);
            tabHome.Size = new Size(792, 366);
            tabHome.TabIndex = 0;
            tabHome.Text = "Home";
            tabHome.UseVisualStyleBackColor = true;
            // 
            // RequestComm
            // 
            RequestComm.AccessibleName = "RequestComm";
            RequestComm.Location = new Point(15, 90);
            RequestComm.Name = "RequestComm";
            RequestComm.Size = new Size(159, 71);
            RequestComm.TabIndex = 0;
            RequestComm.Text = "Request Commission";
            RequestComm.UseVisualStyleBackColor = true;
            RequestComm.Click += RequestComm_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(15, 12);
            label2.Name = "label2";
            label2.Padding = new Padding(10);
            label2.Size = new Size(523, 63);
            label2.TabIndex = 2;
            label2.Text = "Welcome to the commission center...! If you would like to request a commissioned illustration from [Artist1], please press the button below.";
            // 
            // tabInformation
            // 
            tabInformation.Controls.Add(label6);
            tabInformation.Controls.Add(label5);
            tabInformation.Controls.Add(label4);
            tabInformation.Controls.Add(label3);
            tabInformation.Location = new Point(4, 22);
            tabInformation.Name = "tabInformation";
            tabInformation.Padding = new Padding(3);
            tabInformation.Size = new Size(792, 366);
            tabInformation.TabIndex = 1;
            tabInformation.Text = "Information";
            tabInformation.UseVisualStyleBackColor = true;
            // 
            // tabTOS
            // 
            tabTOS.Controls.Add(label8);
            tabTOS.Controls.Add(label7);
            tabTOS.Location = new Point(4, 22);
            tabTOS.Name = "tabTOS";
            tabTOS.Padding = new Padding(3);
            tabTOS.Size = new Size(792, 366);
            tabTOS.TabIndex = 2;
            tabTOS.Text = "Terms Of Service";
            tabTOS.UseVisualStyleBackColor = true;
            // 
            // tabSamples
            // 
            tabSamples.Controls.Add(label10);
            tabSamples.Controls.Add(pictureBox1);
            tabSamples.Controls.Add(label9);
            tabSamples.Location = new Point(4, 22);
            tabSamples.Name = "tabSamples";
            tabSamples.Padding = new Padding(3);
            tabSamples.Size = new Size(792, 366);
            tabSamples.TabIndex = 3;
            tabSamples.Text = "Samples Of Work";
            tabSamples.UseVisualStyleBackColor = true;
            // 
            // tabQueue
            // 
            tabQueue.Controls.Add(label11);
            tabQueue.Controls.Add(tableLayoutPanel1);
            tabQueue.Location = new Point(4, 22);
            tabQueue.Name = "tabQueue";
            tabQueue.Padding = new Padding(3);
            tabQueue.Size = new Size(792, 366);
            tabQueue.TabIndex = 4;
            tabQueue.Text = "Public Queue";
            tabQueue.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(224, 224, 224);
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(8, 53);
            label3.Name = "label3";
            label3.Padding = new Padding(10);
            label3.Size = new Size(769, 70);
            label3.TabIndex = 3;
            label3.Text = "This artist.....\r\n";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(224, 224, 224);
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(8, 14);
            label4.Name = "label4";
            label4.Padding = new Padding(10);
            label4.Size = new Size(769, 39);
            label4.TabIndex = 4;
            label4.Text = "About the Artist";
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(224, 224, 224);
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(8, 143);
            label5.Name = "label5";
            label5.Padding = new Padding(10);
            label5.Size = new Size(769, 39);
            label5.TabIndex = 5;
            label5.Text = "Other Info (tbd)";
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(224, 224, 224);
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(8, 182);
            label6.Name = "label6";
            label6.Padding = new Padding(10);
            label6.Size = new Size(769, 70);
            label6.TabIndex = 6;
            label6.Text = "[wip]";
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(224, 224, 224);
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(8, 14);
            label7.Name = "label7";
            label7.Padding = new Padding(10);
            label7.Size = new Size(769, 39);
            label7.TabIndex = 5;
            label7.Text = "Terms Of Service";
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(224, 224, 224);
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(8, 59);
            label8.Name = "label8";
            label8.Padding = new Padding(10);
            label8.Size = new Size(769, 70);
            label8.TabIndex = 6;
            label8.Text = "[tos]";
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(224, 224, 224);
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(8, 14);
            label9.Name = "label9";
            label9.Padding = new Padding(10);
            label9.Size = new Size(769, 39);
            label9.TabIndex = 6;
            label9.Text = "Samples From [Artist1]";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Untitled;
            pictureBox1.Location = new Point(8, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 231);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 159F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 157F));
            tableLayoutPanel1.Location = new Point(8, 61);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(603, 100);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(224, 224, 224);
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.Location = new Point(8, 15);
            label11.Name = "label11";
            label11.Padding = new Padding(10);
            label11.Size = new Size(769, 39);
            label11.TabIndex = 7;
            label11.Text = "Public Queue\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabAll);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabAll.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            tabInformation.ResumeLayout(false);
            tabTOS.ResumeLayout(false);
            tabSamples.ResumeLayout(false);
            tabQueue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TabControl tabAll;
        private TabPage tabHome;
        private Button RequestComm;
        private Label label2;
        private TabPage tabInformation;
        private TabPage tabTOS;
        private TabPage tabSamples;
        private TabPage tabQueue;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label9;
        private PictureBox pictureBox1;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label11;
    }
}
