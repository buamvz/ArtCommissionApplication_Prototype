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
