namespace GUI_prototype
{
    partial class Form2
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
            label2 = new Label();
            nameInput = new TextBox();
            SubmitRequestButton = new Button();
            label1 = new Label();
            emailInput = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            commissionFormPanel = new Panel();
            needbyDateInput = new Panel();
            inputBoolDateFalse = new RadioButton();
            inputBoolDateTrue = new RadioButton();
            inputNeedByDate = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            descriptionInput = new TextBox();
            backgroundBool = new Panel();
            backgroundBoolTrue = new RadioButton();
            backgroundBoolFalse = new RadioButton();
            label6 = new Label();
            characterNumInput = new Panel();
            characterNumInput5 = new RadioButton();
            characterNumInput4 = new RadioButton();
            characterNumInput3 = new RadioButton();
            characterNumInput2 = new RadioButton();
            characterNumInput1 = new RadioButton();
            cropTypeInput = new Panel();
            cropTypeInputFullbody = new RadioButton();
            cropTypeInputHalfbody = new RadioButton();
            cropTypeInputHeadshot = new RadioButton();
            requestSubmittedPanel = new Panel();
            commissionDetails = new Label();
            label9 = new Label();
            estimatePrice = new Label();
            commissionFormPanel.SuspendLayout();
            needbyDateInput.SuspendLayout();
            backgroundBool.SuspendLayout();
            characterNumInput.SuspendLayout();
            cropTypeInput.SuspendLayout();
            requestSubmittedPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 192, 255);
            label2.Font = new Font("Microsoft Sans Serif", 32.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(394, 51);
            label2.TabIndex = 5;
            label2.Text = "Commission Forms";
            // 
            // nameInput
            // 
            nameInput.Location = new Point(11, 31);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(365, 23);
            nameInput.TabIndex = 2;
            nameInput.Text = "Yuji";
            // 
            // SubmitRequestButton
            // 
            SubmitRequestButton.Location = new Point(14, 749);
            SubmitRequestButton.Name = "SubmitRequestButton";
            SubmitRequestButton.Size = new Size(159, 71);
            SubmitRequestButton.TabIndex = 0;
            SubmitRequestButton.Text = "Submit Request";
            SubmitRequestButton.UseVisualStyleBackColor = true;
            SubmitRequestButton.Click += SubmitRequestButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 13);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Name:";
            // 
            // emailInput
            // 
            emailInput.Location = new Point(11, 83);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(365, 23);
            emailInput.TabIndex = 4;
            emailInput.Text = "ihatemahito123@gmail.com";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 65);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 133);
            label4.Name = "label4";
            label4.Size = new Size(138, 15);
            label4.TabIndex = 8;
            label4.Text = "Type of commissionInfo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 281);
            label5.Name = "label5";
            label5.Size = new Size(234, 15);
            label5.TabIndex = 14;
            label5.Text = "Number of Characters for commissionInfo:";
            // 
            // commissionFormPanel
            // 
            commissionFormPanel.AutoScroll = true;
            commissionFormPanel.BorderStyle = BorderStyle.FixedSingle;
            commissionFormPanel.Controls.Add(needbyDateInput);
            commissionFormPanel.Controls.Add(inputNeedByDate);
            commissionFormPanel.Controls.Add(label8);
            commissionFormPanel.Controls.Add(label7);
            commissionFormPanel.Controls.Add(descriptionInput);
            commissionFormPanel.Controls.Add(backgroundBool);
            commissionFormPanel.Controls.Add(label6);
            commissionFormPanel.Controls.Add(characterNumInput);
            commissionFormPanel.Controls.Add(cropTypeInput);
            commissionFormPanel.Controls.Add(label5);
            commissionFormPanel.Controls.Add(label4);
            commissionFormPanel.Controls.Add(label3);
            commissionFormPanel.Controls.Add(emailInput);
            commissionFormPanel.Controls.Add(label1);
            commissionFormPanel.Controls.Add(SubmitRequestButton);
            commissionFormPanel.Controls.Add(nameInput);
            commissionFormPanel.Location = new Point(12, 77);
            commissionFormPanel.Name = "commissionFormPanel";
            commissionFormPanel.Size = new Size(776, 727);
            commissionFormPanel.TabIndex = 4;
            // 
            // needbyDateInput
            // 
            needbyDateInput.BackColor = SystemColors.Window;
            needbyDateInput.Controls.Add(inputBoolDateFalse);
            needbyDateInput.Controls.Add(inputBoolDateTrue);
            needbyDateInput.Location = new Point(11, 500);
            needbyDateInput.Margin = new Padding(3, 2, 3, 2);
            needbyDateInput.Name = "needbyDateInput";
            needbyDateInput.Size = new Size(114, 33);
            needbyDateInput.TabIndex = 25;
            // 
            // inputBoolDateFalse
            // 
            inputBoolDateFalse.AutoSize = true;
            inputBoolDateFalse.Location = new Point(64, 7);
            inputBoolDateFalse.Margin = new Padding(3, 2, 3, 2);
            inputBoolDateFalse.Name = "inputBoolDateFalse";
            inputBoolDateFalse.Size = new Size(41, 19);
            inputBoolDateFalse.TabIndex = 4;
            inputBoolDateFalse.TabStop = true;
            inputBoolDateFalse.Text = "No";
            inputBoolDateFalse.UseVisualStyleBackColor = true;
            // 
            // inputBoolDateTrue
            // 
            inputBoolDateTrue.AutoSize = true;
            inputBoolDateTrue.Location = new Point(7, 7);
            inputBoolDateTrue.Margin = new Padding(3, 2, 3, 2);
            inputBoolDateTrue.Name = "inputBoolDateTrue";
            inputBoolDateTrue.Size = new Size(42, 19);
            inputBoolDateTrue.TabIndex = 3;
            inputBoolDateTrue.TabStop = true;
            inputBoolDateTrue.Text = "Yes";
            inputBoolDateTrue.UseVisualStyleBackColor = true;
            // 
            // inputNeedByDate
            // 
            inputNeedByDate.Location = new Point(38, 538);
            inputNeedByDate.Name = "inputNeedByDate";
            inputNeedByDate.Size = new Size(200, 23);
            inputNeedByDate.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 483);
            label8.Name = "label8";
            label8.Size = new Size(130, 15);
            label8.TabIndex = 27;
            label8.Text = "Need by a certain date?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 567);
            label7.Name = "label7";
            label7.Size = new Size(144, 15);
            label7.TabIndex = 26;
            label7.Text = "Specifices of commisions:";
            // 
            // descriptionInput
            // 
            descriptionInput.Location = new Point(11, 585);
            descriptionInput.Multiline = true;
            descriptionInput.Name = "descriptionInput";
            descriptionInput.Size = new Size(420, 133);
            descriptionInput.TabIndex = 25;
            descriptionInput.Text = "Junpei and me at the park";
            // 
            // backgroundBool
            // 
            backgroundBool.BackColor = SystemColors.Window;
            backgroundBool.Controls.Add(backgroundBoolTrue);
            backgroundBool.Controls.Add(backgroundBoolFalse);
            backgroundBool.Location = new Point(14, 398);
            backgroundBool.Margin = new Padding(3, 2, 3, 2);
            backgroundBool.Name = "backgroundBool";
            backgroundBool.Size = new Size(139, 72);
            backgroundBool.TabIndex = 24;
            // 
            // backgroundBoolTrue
            // 
            backgroundBoolTrue.AutoSize = true;
            backgroundBoolTrue.Location = new Point(10, 39);
            backgroundBoolTrue.Margin = new Padding(3, 2, 3, 2);
            backgroundBoolTrue.Name = "backgroundBoolTrue";
            backgroundBoolTrue.Size = new Size(89, 19);
            backgroundBoolTrue.TabIndex = 2;
            backgroundBoolTrue.TabStop = true;
            backgroundBoolTrue.Text = "Background";
            backgroundBoolTrue.UseVisualStyleBackColor = true;
            // 
            // backgroundBoolFalse
            // 
            backgroundBoolFalse.AutoSize = true;
            backgroundBoolFalse.Location = new Point(10, 12);
            backgroundBoolFalse.Margin = new Padding(3, 2, 3, 2);
            backgroundBoolFalse.Name = "backgroundBoolFalse";
            backgroundBoolFalse.Size = new Size(108, 19);
            backgroundBoolFalse.TabIndex = 0;
            backgroundBoolFalse.TabStop = true;
            backgroundBoolFalse.Text = "No Background";
            backgroundBoolFalse.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 374);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 23;
            label6.Text = "Background Type:";
            // 
            // characterNumInput
            // 
            characterNumInput.BackColor = SystemColors.Window;
            characterNumInput.Controls.Add(characterNumInput5);
            characterNumInput.Controls.Add(characterNumInput4);
            characterNumInput.Controls.Add(characterNumInput3);
            characterNumInput.Controls.Add(characterNumInput2);
            characterNumInput.Controls.Add(characterNumInput1);
            characterNumInput.Location = new Point(11, 308);
            characterNumInput.Margin = new Padding(3, 2, 3, 2);
            characterNumInput.Name = "characterNumInput";
            characterNumInput.Size = new Size(312, 52);
            characterNumInput.TabIndex = 22;
            // 
            // characterNumInput5
            // 
            characterNumInput5.AutoSize = true;
            characterNumInput5.CheckAlign = ContentAlignment.TopCenter;
            characterNumInput5.Location = new Point(260, 10);
            characterNumInput5.Margin = new Padding(3, 2, 3, 2);
            characterNumInput5.Name = "characterNumInput5";
            characterNumInput5.Size = new Size(17, 32);
            characterNumInput5.TabIndex = 4;
            characterNumInput5.Text = "5";
            characterNumInput5.UseVisualStyleBackColor = true;
            // 
            // characterNumInput4
            // 
            characterNumInput4.AutoSize = true;
            characterNumInput4.CheckAlign = ContentAlignment.TopCenter;
            characterNumInput4.Location = new Point(204, 10);
            characterNumInput4.Margin = new Padding(3, 2, 3, 2);
            characterNumInput4.Name = "characterNumInput4";
            characterNumInput4.Size = new Size(17, 32);
            characterNumInput4.TabIndex = 3;
            characterNumInput4.Text = "4";
            characterNumInput4.UseVisualStyleBackColor = true;
            // 
            // characterNumInput3
            // 
            characterNumInput3.AutoSize = true;
            characterNumInput3.CheckAlign = ContentAlignment.TopCenter;
            characterNumInput3.Location = new Point(144, 10);
            characterNumInput3.Margin = new Padding(3, 2, 3, 2);
            characterNumInput3.Name = "characterNumInput3";
            characterNumInput3.Size = new Size(17, 32);
            characterNumInput3.TabIndex = 2;
            characterNumInput3.Text = "3";
            characterNumInput3.UseVisualStyleBackColor = true;
            // 
            // characterNumInput2
            // 
            characterNumInput2.AutoSize = true;
            characterNumInput2.CheckAlign = ContentAlignment.TopCenter;
            characterNumInput2.Location = new Point(85, 10);
            characterNumInput2.Margin = new Padding(3, 2, 3, 2);
            characterNumInput2.Name = "characterNumInput2";
            characterNumInput2.Size = new Size(17, 32);
            characterNumInput2.TabIndex = 1;
            characterNumInput2.Text = "2";
            characterNumInput2.UseVisualStyleBackColor = true;
            // 
            // characterNumInput1
            // 
            characterNumInput1.AutoSize = true;
            characterNumInput1.CheckAlign = ContentAlignment.TopCenter;
            characterNumInput1.Checked = true;
            characterNumInput1.Location = new Point(27, 10);
            characterNumInput1.Margin = new Padding(3, 2, 3, 2);
            characterNumInput1.Name = "characterNumInput1";
            characterNumInput1.Size = new Size(17, 32);
            characterNumInput1.TabIndex = 0;
            characterNumInput1.TabStop = true;
            characterNumInput1.Text = "1";
            characterNumInput1.UseVisualStyleBackColor = true;
            // 
            // cropTypeInput
            // 
            cropTypeInput.BackColor = SystemColors.Window;
            cropTypeInput.Controls.Add(cropTypeInputFullbody);
            cropTypeInput.Controls.Add(cropTypeInputHalfbody);
            cropTypeInput.Controls.Add(cropTypeInputHeadshot);
            cropTypeInput.Location = new Point(11, 157);
            cropTypeInput.Margin = new Padding(3, 2, 3, 2);
            cropTypeInput.Name = "cropTypeInput";
            cropTypeInput.Size = new Size(114, 108);
            cropTypeInput.TabIndex = 21;
            // 
            // cropTypeInputFullbody
            // 
            cropTypeInputFullbody.AutoSize = true;
            cropTypeInputFullbody.Location = new Point(10, 76);
            cropTypeInputFullbody.Margin = new Padding(3, 2, 3, 2);
            cropTypeInputFullbody.Name = "cropTypeInputFullbody";
            cropTypeInputFullbody.Size = new Size(74, 19);
            cropTypeInputFullbody.TabIndex = 2;
            cropTypeInputFullbody.TabStop = true;
            cropTypeInputFullbody.Text = "Full Body";
            cropTypeInputFullbody.UseVisualStyleBackColor = true;
            // 
            // cropTypeInputHalfbody
            // 
            cropTypeInputHalfbody.AutoSize = true;
            cropTypeInputHalfbody.Location = new Point(10, 43);
            cropTypeInputHalfbody.Margin = new Padding(3, 2, 3, 2);
            cropTypeInputHalfbody.Name = "cropTypeInputHalfbody";
            cropTypeInputHalfbody.Size = new Size(77, 19);
            cropTypeInputHalfbody.TabIndex = 1;
            cropTypeInputHalfbody.TabStop = true;
            cropTypeInputHalfbody.Text = "Half Body";
            cropTypeInputHalfbody.UseVisualStyleBackColor = true;
            // 
            // cropTypeInputHeadshot
            // 
            cropTypeInputHeadshot.AutoSize = true;
            cropTypeInputHeadshot.Location = new Point(10, 10);
            cropTypeInputHeadshot.Margin = new Padding(3, 2, 3, 2);
            cropTypeInputHeadshot.Name = "cropTypeInputHeadshot";
            cropTypeInputHeadshot.Size = new Size(80, 19);
            cropTypeInputHeadshot.TabIndex = 0;
            cropTypeInputHeadshot.TabStop = true;
            cropTypeInputHeadshot.Text = "Head Shot";
            cropTypeInputHeadshot.UseVisualStyleBackColor = true;
            // 
            // requestSubmittedPanel
            // 
            requestSubmittedPanel.Controls.Add(commissionDetails);
            requestSubmittedPanel.Controls.Add(label9);
            requestSubmittedPanel.Enabled = false;
            requestSubmittedPanel.Location = new Point(12, 77);
            requestSubmittedPanel.Name = "requestSubmittedPanel";
            requestSubmittedPanel.Size = new Size(776, 430);
            requestSubmittedPanel.TabIndex = 6;
            requestSubmittedPanel.Visible = false;
            // 
            // commissionDetails
            // 
            commissionDetails.Font = new Font("Segoe UI", 12F);
            commissionDetails.Location = new Point(19, 128);
            commissionDetails.Name = "commissionDetails";
            commissionDetails.Size = new Size(736, 281);
            commissionDetails.TabIndex = 5;
            commissionDetails.Text = "[details]\r\n";
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(15, 14);
            label9.Name = "label9";
            label9.Size = new Size(708, 218);
            label9.TabIndex = 4;
            label9.Text = "Thank you for your commission! [Artist] will get back to you shortly about your acceptance. \r\n\r\nYour commission details are as follows:\r\n";
            // 
            // estimatePrice
            // 
            estimatePrice.AutoSize = true;
            estimatePrice.Font = new Font("Segoe UI", 14F);
            estimatePrice.Location = new Point(515, 49);
            estimatePrice.Name = "estimatePrice";
            estimatePrice.Size = new Size(205, 25);
            estimatePrice.TabIndex = 7;
            estimatePrice.Text = "Estimated Price (NZD): ";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 808);
            Controls.Add(estimatePrice);
            Controls.Add(requestSubmittedPanel);
            Controls.Add(label2);
            Controls.Add(commissionFormPanel);
            Name = "Form2";
            Text = "Form2";
            commissionFormPanel.ResumeLayout(false);
            commissionFormPanel.PerformLayout();
            needbyDateInput.ResumeLayout(false);
            needbyDateInput.PerformLayout();
            backgroundBool.ResumeLayout(false);
            backgroundBool.PerformLayout();
            characterNumInput.ResumeLayout(false);
            characterNumInput.PerformLayout();
            cropTypeInput.ResumeLayout(false);
            cropTypeInput.PerformLayout();
            requestSubmittedPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox nameInput;
        private Button SubmitRequestButton;
        private Label label1;
        private TextBox emailInput;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel commissionFormPanel;
        private Panel cropTypeInput;
        private RadioButton cropTypeInputFullbody;
        private RadioButton cropTypeInputHalfbody;
        private RadioButton cropTypeInputHeadshot;
        private Panel characterNumInput;
        private RadioButton characterNumInput5;
        private RadioButton characterNumInput4;
        private RadioButton characterNumInput3;
        private RadioButton characterNumInput2;
        private RadioButton characterNumInput1;
        private Panel backgroundBool;
        private RadioButton backgroundBoolTrue;
        private RadioButton backgroundBoolFalse;
        private Label label6;
        private Label label7;
        private TextBox descriptionInput;
        private Label label8;
        private RadioButton inputBoolDateTrue;
        private DateTimePicker inputNeedByDate;
        private Panel requestSubmittedPanel;
        private Label label9;
        private Label commissionDetails;
        private Panel needbyDateInput;
        private RadioButton inputBoolDateFalse;
        private Label estimatePrice;
    }
}