using ArtCommissionApplication_Prototype;
using static ArtCommissionApplication_Prototype.CommissionInformation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_prototype
{
    public partial class Form2 : Form
    {
        private Client client;
        private CommissionInformation commissionInfo;
        private CommissionRequest commission;

        private string inputName;
        private string inputEmail;
        private CharacterCrop inputCrop;
        private int inputCharactersNumber;
        private bool inputBackground;
        private string inputDescription;
        private DateTime inputDate;

        private string finalCommissionDetails;

        public Form2()
        {
            InitializeComponent();

            // wire up change events so the estimate updates when inputs change
            cropTypeInputHeadshot.CheckedChanged += (s, e) => UpdateEstimate();
            cropTypeInputHalfbody.CheckedChanged += (s, e) => UpdateEstimate();
            cropTypeInputFullbody.CheckedChanged += (s, e) => UpdateEstimate();

            backgroundBoolTrue.CheckedChanged += (s, e) => UpdateEstimate();
            backgroundBoolFalse.CheckedChanged += (s, e) => UpdateEstimate();

            characterNumInput1.CheckedChanged += (s, e) => UpdateEstimate();
            characterNumInput2.CheckedChanged += (s, e) => UpdateEstimate();
            characterNumInput3.CheckedChanged += (s, e) => UpdateEstimate();
            characterNumInput4.CheckedChanged += (s, e) => UpdateEstimate();
            characterNumInput5.CheckedChanged += (s, e) => UpdateEstimate();

            // update immediately to reflect any default selections
            UpdateEstimate();
        }

        public void Update()
        {
            // kept for compatibility with existing code; forward to UpdateEstimate
            UpdateEstimate();
        }

        private void UpdateEstimate()
        {
            // Determine selected crop
            bool cropSelected = false;
            CharacterCrop crop = CharacterCrop.Headshot;

            if (cropTypeInputHeadshot.Checked)
            {
                crop = CharacterCrop.Headshot;
                cropSelected = true;
            }
            else if (cropTypeInputHalfbody.Checked)
            {
                crop = CharacterCrop.Halfbody;
                cropSelected = true;
            }
            else if (cropTypeInputFullbody.Checked)
            {
                crop = CharacterCrop.Fullbody;
                cropSelected = true;
            }

            if (!cropSelected)
            {
                estimatePrice.Text = "Estimated Price (NZD): -";
                return;
            }
            // determine number of characters selected
            int numberOfCharacters = 1;
            if (characterNumInput1.Checked) numberOfCharacters = 1;
            else if (characterNumInput2.Checked) numberOfCharacters = 2;
            else if (characterNumInput3.Checked) numberOfCharacters = 3;
            else if (characterNumInput4.Checked) numberOfCharacters = 4;
            else if (characterNumInput5.Checked) numberOfCharacters = 5;

            bool hasBackground = backgroundBoolTrue.Checked;

            // Use the shared estimator on CommissionInformation. This avoids constructing a validated object
            // (which would currently require description/date validations).
            decimal calculated = CommissionInformation.EstimatePriceFor(crop, hasBackground, numberOfCharacters);

            estimatePrice.Text = $"Estimated Price (NZD): {calculated:C}";
        }

        // assignemt logic done after submit has been clicked
        private void SubmitRequestButton_Click(object sender, EventArgs e)
        {
            // === client info ===
            // name
            inputName = nameInput.Text;

            // email
            inputEmail = emailInput.Text;


            // === commissions info ===

            // character crop height
            if (cropTypeInputHeadshot.Checked)
                inputCrop = CharacterCrop.Headshot;
            else if (cropTypeInputHeadshot.Checked)
                inputCrop = CharacterCrop.Halfbody;
            else if (cropTypeInputHeadshot.Checked)
                inputCrop = CharacterCrop.Fullbody;

            // number of charcters
            if (characterNumInput1.Checked)
            {
                inputCharactersNumber = 1;
            }
            else if (characterNumInput2.Checked)
            {
                inputCharactersNumber = 2;
            }
            else if (characterNumInput3.Checked)
            {
                inputCharactersNumber = 3;
            }
            else if (characterNumInput4.Checked)
            {
                inputCharactersNumber = 4;
            }
            else if (characterNumInput5.Checked)
            {
                inputCharactersNumber = 5;
            }

            // background
            if (!backgroundBoolTrue.Checked)
                inputBackground = true;
            else if (!backgroundBoolTrue.Checked)
                inputBackground = false;


            // check need by date
            if (inputBoolDateTrue.Checked)
            {
                inputDate = inputNeedByDate.Value;
            }
            else
            {
                inputDate = DateTime.Today.AddDays(365); // if no given date - assume one year max
            }

            // description
            inputDescription = descriptionInput.Text;

            client = new Client(inputName, inputEmail);
            commissionInfo = new CommissionInformation(inputCrop, inputCharactersNumber, inputBackground, inputDescription, inputDate);
            commission = new CommissionRequest(client, commissionInfo);

            commissionInfo.RecalculateEstimate(); // recalcultes estimate to be sure it's correct

            finalCommissionDetails =
                "=== Client (You) === \n" +
                "Name: " + client.ClientName + "\n" +
                "Email: " + client.ClientEmail + "\n \n" +

                "=== Commission Details === \n" +
                "Character Crop: " + commissionInfo.CropType + "\n" +
                "Number of Characters: " + commissionInfo.NumberOFCharacters + "\n" +
                "Need by Date: " + commissionInfo.NeedByDate + "\n" +
                "Description: " + commissionInfo.Description + "\n \n" +
                $"Estimated Price: {commissionInfo.EstimatedPrice:C}" +  "\n"

                ;

            commissionFormPanel.Visible = false;
            commissionFormPanel.Enabled = false;
            requestSubmittedPanel.Visible = true;
            requestSubmittedPanel.Enabled = true;
            estimatePrice.Visible = false;
            estimatePrice.Enabled = false;

            commissionDetails.Text = finalCommissionDetails;
        }

    }
}
