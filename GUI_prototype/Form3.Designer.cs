namespace GUI_prototype
{
    partial class Form3
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
            ClientButton = new Button();
            ArtistButton = new Button();
            SuspendLayout();
            // 
            // ClientButton
            // 
            ClientButton.Location = new Point(249, 170);
            ClientButton.Name = "ClientButton";
            ClientButton.Size = new Size(145, 75);
            ClientButton.TabIndex = 0;
            ClientButton.Text = "Client";
            ClientButton.UseVisualStyleBackColor = true;
            ClientButton.Click += ClientButton_Click;
            // 
            // ArtistButton
            // 
            ArtistButton.Location = new Point(410, 170);
            ArtistButton.Name = "ArtistButton";
            ArtistButton.Size = new Size(145, 75);
            ArtistButton.TabIndex = 1;
            ArtistButton.Text = "Artist";
            ArtistButton.UseVisualStyleBackColor = true;
            ArtistButton.Click += ArtistButton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ArtistButton);
            Controls.Add(ClientButton);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private Button ClientButton;
        private Button ArtistButton;
    }
}