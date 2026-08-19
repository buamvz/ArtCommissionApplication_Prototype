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
            RequestComm = new Button();
            panel1 = new Panel();
            textBox2 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // RequestComm
            // 
            RequestComm.AccessibleName = "RequestComm";
            RequestComm.Location = new Point(14, 82);
            RequestComm.Name = "RequestComm";
            RequestComm.Size = new Size(159, 71);
            RequestComm.TabIndex = 0;
            RequestComm.Text = "Request Commission";
            RequestComm.UseVisualStyleBackColor = true;
            RequestComm.Click += RequestComm_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(RequestComm);
            panel1.Location = new Point(12, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 361);
            panel1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(14, 13);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(550, 63);
            textBox2.TabIndex = 1;
            textBox2.Text = "Welcome to the commission center...! If you would like to request a commissioned illustration from [Artist1], please press the button below.";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Font = new Font("SWItal", 32.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(584, 55);
            label1.TabIndex = 3;
            label1.Text = "Commission [Artist1]";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RequestComm;
        private Panel panel1;
        private TextBox textBox2;
        private Label label1;
    }
}
