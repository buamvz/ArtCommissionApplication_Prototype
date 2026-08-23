using ArtCommisionApplication;
using ArtCommissionApplication_Prototype;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using static ArtCommissionApplication_Prototype.CommissionInformation;


namespace ArtCommisionApplication.Test
{
    [TestClass]
    public class CommissionRequestTests
    {
        [TestMethod]
        public void Client_EmptyClientName_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new Client("", "mahitohater67@gmail.com"));
        }

        [TestMethod]
        public void Client_EmptyClientEmail_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new Client("Yuji", ""));
        }

        // Sienna - don't think this is possible with current code?
        //[TestMethod]
        //public void CommissionInformation_NegativePrice_ThrowsException()
        //{
        //    // CharacterCrop characterCrop, bool hasBackground, string description, DateTime? needByDate
        //    Assert.ThrowsException<ArgumentException>(() =>
        //        new CommissionInformation(CharacterCrop.Fullbody, true, "Me and Junpei having a picnic", DateTime.Today.AddDays(8)));
        //}


        [TestMethod]
        public void CommissionRequest_ValidDetails_CreatesPendingRequest()
        {
            var client = new Client("Yuji", "mahitohater67@gmail.com");
            var commission = new CommissionInformation(CharacterCrop.Fullbody, 2, true, "Me and Junpei having a picnic", DateTime.Today.AddDays(8));

            var request = new CommissionRequest(client, commission);

            Assert.AreEqual(CommissionStatus.Pending, request.Status);
        }

        [TestMethod]
        public void CommissionRequest_EmptyDescription_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new CommissionInformation(CharacterCrop.Fullbody, 2, true, "", DateTime.Today.AddDays(8)));

        }

        // Brooke - checking a past date 
        //past date will be rejected (business rule defect prevention) 
        //vaild future date will be accepted

        [TestMethod]
        public void CommissionInformation_PastNeedByDate_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new CommissionInformation(CharacterCrop.Fullbody, 2, true, "Me and Junpei having a picnic", DateTime.Today.AddDays(-1)));
        }

        [TestMethod]
        public void CommissionInformation_FutureNeedByDate_CreatesCommission()
        {
            var commission = new CommissionInformation(CharacterCrop.Fullbody, 2, true, "Me and Junpei having a picnic", DateTime.Today.AddDays(7));

            Assert.AreEqual(DateTime.Today.AddDays(7), commission.NeedByDate.Value.Date);
        }

        //invaild and vaild email test for new mailAddress in client
        [TestMethod]
        public void Client_InvalidEmail_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new Client("Yuji", "noemailhere"));
        }

        [TestMethod]
        public void Client_ValidEmail_CreatesClient()
        {
            var client = new Client("Yuji", "mahitohater67@gmail.com");

            Assert.AreEqual("Yuji", client.ClientName);
            Assert.AreEqual("mahitohater67@gmail.com", client.ClientEmail);
        }

        [TestMethod]
        public void CommissionInformation_MoreThanFiveCharacters_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new CommissionInformation(CharacterCrop.Fullbody, 6, true, "Me and Junpei having a picnic", DateTime.Today.AddDays(7)));
        }

        [TestMethod]
        public void CommissionInformation_ZeroCharacters_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new CommissionInformation(CharacterCrop.Fullbody, 0, true, "Me and Junpei having a picnic", DateTime.Today.AddDays(7)));
        }

        [TestMethod]
        public void CommissionInformation_OneCharacter_CreatesCommission()
        {
            var commission = new CommissionInformation(CharacterCrop.Headshot, 1, false, "A", DateTime.Today.AddDays(7));

            Assert.AreEqual(1, commission.NumberOFCharacters);
        }

        [TestMethod]
        public void CommissionInformation_FiveCharacters_CreatesCommission()
        {
            var commission = new CommissionInformation(CharacterCrop.Fullbody, 5, true, "Group of five", DateTime.Today.AddDays(7));

            Assert.AreEqual(5, commission.NumberOFCharacters);
        }

        [TestMethod]
        public void CommissionInformation_NegativeCharacters_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new CommissionInformation(CharacterCrop.Halfbody, -1, false, "Invalid negative", DateTime.Today.AddDays(7)));
        }

    }
}
