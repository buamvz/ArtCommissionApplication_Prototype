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
            tabInformation = new TabPage();
            label2 = new Label();
            RequestComm = new Button();
            tabHome = new TabPage();
            tabTOS = new TabPage();
            tabSamples = new TabPage();
            tabQueue = new TabPage();
            tabAll.SuspendLayout();
            tabHome.SuspendLayout();
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
            // tabInformation
            // 
            tabInformation.Location = new Point(4, 22);
            tabInformation.Name = "tabInformation";
            tabInformation.Padding = new Padding(3);
            tabInformation.Size = new Size(792, 366);
            tabInformation.TabIndex = 1;
            tabInformation.Text = "Information";
            tabInformation.UseVisualStyleBackColor = true;
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
            // tabTOS
            // 
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
            tabQueue.Location = new Point(4, 22);
            tabQueue.Name = "tabQueue";
            tabQueue.Padding = new Padding(3);
            tabQueue.Size = new Size(792, 366);
            tabQueue.TabIndex = 4;
            tabQueue.Text = "Public Queue";
            tabQueue.UseVisualStyleBackColor = true;
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
    }
}
