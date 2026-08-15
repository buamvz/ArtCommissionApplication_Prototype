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
            var commission = new CommissionInformation(CharacterCrop.Fullbody, true, "Me and Junpei having a picnic", DateTime.Today.AddDays(8));

            var request = new CommissionRequest(client, commission);

            Assert.AreEqual(CommissionStatus.Pending, request.Status);
        }

        [TestMethod]
        public void CommissionRequest_EmptyDescription_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new CommissionInformation(CharacterCrop.Fullbody, true, "", DateTime.Today.AddDays(8)));

        }

        // Brooke - checking a past date 
        //past date will be rejected (business rule defect prevention) 
        //vaild future date will be accepted

        [TestMethod]
        public void CommissionInformation_PastNeedByDate_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new CommissionInformation(CharacterCrop.Fullbody, true, "Me and Junpei having a picnic", DateTime.Today.AddDays(-1)));
        }

        [TestMethod]
        public void CommissionInformation_FutureNeedByDate_CreatesCommission()
        {
            var commission = new CommissionInformation(CharacterCrop.Fullbody, true, "Me and Junpei having a picnic", DateTime.Today.AddDays(7));

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




        /* Sienna - old version of tests (similar tests above)
        
        [TestMethod]
        public void CommissionRequest_EmptyClientName_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new CommissionRequest("C001", "", "mahitohater67@gmail.com", "Half Body drawing", "Me and Junpei having a picnic", 100m));
        }

        [TestMethod]
        public void CommissionRequest_EmptyClientEmail_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new CommissionRequest("C001", "Yuji", "", "Half Body drawing", "Me and Junpei having a picnic", 100m));
        }

        [TestMethod]
        public void CommissionRequest_NegativePrice_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new CommissionRequest("C001", "Yuji", "mahitohater67@gmail.com", "Half Body drawing", "Me and Junpei having a picnic", -50m));
        }


        [TestMethod]
        public void CommissionRequest_ValidDetails_CreatesPendingRequest()
        {
            var request = new CommissionRequest("C001", "Yuji", "mahitohater67@gmail.com", "Half Body drawing", "Me and Junpei having a picnic", 100m);

            Assert.AreEqual(CommissionStatus.Pending, request.Status);
        }

        [TestMethod]
        public void CommissionRequest_EmptyDescription_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new CommissionRequest("C001", "Yuji", "mahitohater67@gmail.com", "Half Body drawing", "", 100m));

        }
        */
    }
}
