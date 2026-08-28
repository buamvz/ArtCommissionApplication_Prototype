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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tabTOS = new TabPage();
            label8 = new Label();
            label7 = new Label();
            tabSamples = new TabPage();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            tabQueue = new TabPage();
            label11 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tabAll.SuspendLayout();
            tabHome.SuspendLayout();
            tabInformation.SuspendLayout();
            tabTOS.SuspendLayout();
            tabSamples.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabQueue.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(914, 73);
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
            tabAll.Location = new Point(0, 77);
            tabAll.Margin = new Padding(3, 4, 3, 4);
            tabAll.Name = "tabAll";
            tabAll.SelectedIndex = 0;
            tabAll.Size = new Size(914, 523);
            tabAll.TabIndex = 3;
            // 
            // tabHome
            // 
            tabHome.Controls.Add(RequestComm);
            tabHome.Controls.Add(label2);
            tabHome.Location = new Point(4, 26);
            tabHome.Margin = new Padding(3, 4, 3, 4);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(3, 4, 3, 4);
            tabHome.Size = new Size(906, 493);
            tabHome.TabIndex = 0;
            tabHome.Text = "Home";
            tabHome.UseVisualStyleBackColor = true;
            // 
            // RequestComm
            // 
            RequestComm.AccessibleName = "RequestComm";
            RequestComm.Location = new Point(17, 120);
            RequestComm.Margin = new Padding(3, 4, 3, 4);
            RequestComm.Name = "RequestComm";
            RequestComm.Size = new Size(182, 62);
            RequestComm.TabIndex = 0;
            RequestComm.Text = "Request Commission Form";
            RequestComm.UseVisualStyleBackColor = true;
            RequestComm.Click += RequestComm_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(17, 16);
            label2.Name = "label2";
            label2.Padding = new Padding(11, 13, 11, 13);
            label2.Size = new Size(598, 84);
            label2.TabIndex = 2;
            label2.Text = "Welcome to the commissionInfo center...! If you would like to request a commissioned illustration from [Artist1], please press the button below.";
            // 
            // tabInformation
            // 
            tabInformation.Controls.Add(label6);
            tabInformation.Controls.Add(label5);
            tabInformation.Controls.Add(label4);
            tabInformation.Controls.Add(label3);
            tabInformation.Location = new Point(4, 26);
            tabInformation.Margin = new Padding(3, 4, 3, 4);
            tabInformation.Name = "tabInformation";
            tabInformation.Padding = new Padding(3, 4, 3, 4);
            tabInformation.Size = new Size(906, 493);
            tabInformation.TabIndex = 1;
            tabInformation.Text = "Information";
            tabInformation.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(224, 224, 224);
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(9, 243);
            label6.Name = "label6";
            label6.Padding = new Padding(11, 13, 11, 13);
            label6.Size = new Size(879, 93);
            label6.TabIndex = 6;
            label6.Text = "[wip]";
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(224, 224, 224);
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(9, 191);
            label5.Name = "label5";
            label5.Padding = new Padding(11, 13, 11, 13);
            label5.Size = new Size(879, 52);
            label5.TabIndex = 5;
            label5.Text = "Other Info (tbd)";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(224, 224, 224);
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(9, 19);
            label4.Name = "label4";
            label4.Padding = new Padding(11, 13, 11, 13);
            label4.Size = new Size(879, 52);
            label4.TabIndex = 4;
            label4.Text = "About the Artist";
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(224, 224, 224);
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(9, 71);
            label3.Name = "label3";
            label3.Padding = new Padding(11, 13, 11, 13);
            label3.Size = new Size(879, 93);
            label3.TabIndex = 3;
            label3.Text = "This artist.....\r\n";
            // 
            // tabTOS
            // 
            tabTOS.Controls.Add(label8);
            tabTOS.Controls.Add(label7);
            tabTOS.Location = new Point(4, 26);
            tabTOS.Margin = new Padding(3, 4, 3, 4);
            tabTOS.Name = "tabTOS";
            tabTOS.Padding = new Padding(3, 4, 3, 4);
            tabTOS.Size = new Size(906, 493);
            tabTOS.TabIndex = 2;
            tabTOS.Text = "Terms Of Service";
            tabTOS.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.BackColor = Color.FromArgb(224, 224, 224);
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(9, 79);
            label8.Name = "label8";
            label8.Padding = new Padding(11, 13, 11, 13);
            label8.Size = new Size(879, 93);
            label8.TabIndex = 6;
            label8.Text = "[tos]";
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(224, 224, 224);
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(9, 19);
            label7.Name = "label7";
            label7.Padding = new Padding(11, 13, 11, 13);
            label7.Size = new Size(879, 52);
            label7.TabIndex = 5;
            label7.Text = "Terms Of Service";
            // 
            // tabSamples
            // 
            tabSamples.Controls.Add(label10);
            tabSamples.Controls.Add(pictureBox1);
            tabSamples.Controls.Add(label9);
            tabSamples.Location = new Point(4, 26);
            tabSamples.Margin = new Padding(3, 4, 3, 4);
            tabSamples.Name = "tabSamples";
            tabSamples.Padding = new Padding(3, 4, 3, 4);
            tabSamples.Size = new Size(906, 493);
            tabSamples.TabIndex = 3;
            tabSamples.Text = "Samples Of Work";
            tabSamples.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 12F);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(241, 75);
            label10.Name = "label10";
            label10.Padding = new Padding(11, 13, 11, 13);
            label10.Size = new Size(282, 187);
            label10.TabIndex = 8;
            label10.Text = "Note: samples will be listed in date order with short labels if needed - or tool tips?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Untitled;
            pictureBox1.Location = new Point(9, 75);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 308);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(224, 224, 224);
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(9, 19);
            label9.Name = "label9";
            label9.Padding = new Padding(11, 13, 11, 13);
            label9.Size = new Size(879, 52);
            label9.TabIndex = 6;
            label9.Text = "Samples From [Artist1]";
            // 
            // tabQueue
            // 
            tabQueue.Controls.Add(label11);
            tabQueue.Controls.Add(tableLayoutPanel1);
            tabQueue.Location = new Point(4, 26);
            tabQueue.Margin = new Padding(3, 4, 3, 4);
            tabQueue.Name = "tabQueue";
            tabQueue.Padding = new Padding(3, 4, 3, 4);
            tabQueue.Size = new Size(906, 493);
            tabQueue.TabIndex = 4;
            tabQueue.Text = "Public Queue";
            tabQueue.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(224, 224, 224);
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.Location = new Point(9, 20);
            label11.Name = "label11";
            label11.Padding = new Padding(11, 13, 11, 13);
            label11.Size = new Size(879, 52);
            label11.TabIndex = 7;
            label11.Text = "Public Queue\r\n";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 182F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 181F));
            tableLayoutPanel1.Location = new Point(9, 81);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(689, 133);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tabAll);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabAll.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            tabInformation.ResumeLayout(false);
            tabTOS.ResumeLayout(false);
            tabSamples.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabQueue.ResumeLayout(false);
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
