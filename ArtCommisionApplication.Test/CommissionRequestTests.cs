using ArtCommisionApplication;
using ArtCommissionApplication_Prototype;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ArtCommisionApplication.Test
{
    [TestClass]
    public class CommissionRequestTests
    {
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
     }
}
