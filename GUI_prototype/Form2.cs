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

            finalCommissionDetails =
                "Name: " + client.ClientName + "\n" +
                "Email: " + client.ClientEmail + "\n" +

                "Character Crop: " + commissionInfo.CropType + "\n" +
                "Number of Characters: " + commissionInfo.NumberOFCharacters + "\n" +
                "Need by Date: " + commissionInfo.NeedByDate + "\n" +
                "Description: " + commissionInfo.Description + "\n"

                ;

            commissionFormPanel.Visible = false;
            commissionFormPanel.Enabled = false;
            requestSubmittedPanel.Visible = true;
            requestSubmittedPanel.Enabled = true;

            commissionDetails.Text = finalCommissionDetails;
        }
    }
}
