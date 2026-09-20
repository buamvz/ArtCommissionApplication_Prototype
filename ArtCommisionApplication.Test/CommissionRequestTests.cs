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

        //queue prototype test
        [TestMethod]
        public void CommissionQueue_AddCommission_AddsToQueue()
        {
            var client = new Client("Yuji", "mahitohater67@gmail.com");

            var commission = new CommissionInformation(CommissionInformation.CharacterCrop.Fullbody, 2, true, "Me and Junpei having a picnic", DateTime.Today.AddDays(7));

            var request = new CommissionRequest(client, commission);

            var queue = new CommissionQueue();

            queue.AddCommission(request);

            Assert.AreEqual(1, queue.Count);
        }

        [TestMethod]
        public void CommissionQueue_GetQueuePosition_ReturnsCorrectPosition()
        {
            var client1 = new Client("Yuji", "yuji@example.com");
            var commission1 = new CommissionInformation(CommissionInformation.CharacterCrop.Headshot, 1, false, "First commission", DateTime.Today.AddDays(7));

            var client2 = new Client("Megumi", "megumi@example.com");
            var commission2 = new CommissionInformation(CommissionInformation.CharacterCrop.Fullbody, 1, true, "Second commission", DateTime.Today.AddDays(7));

            var request1 = new CommissionRequest(client1, commission1);
            var request2 = new CommissionRequest(client2, commission2);

            var queue = new CommissionQueue();

            queue.AddCommission(request1);
            queue.AddCommission(request2);

            Assert.AreEqual(1, queue.GetQueuePosition(request1));
            Assert.AreEqual(2, queue.GetQueuePosition(request2));
        }

        //testing database and queue intergration for loading a commission from new database Sienna made

        [TestMethod]
        public void CommissionQueue_LoadFromDatabase_LoadsStoredCommissions()
        {
            string testDatabasePath = System.IO.Path.Combine(
                System.IO.Path.GetTempPath(),
                "ArtCommissionTest.db");

            CommissionRepository.Initialize(testDatabasePath);

            var client = new Client(
                "Yuji",
                "yuji@gmail.com");

            var commission = new CommissionInformation(
                CharacterCrop.Fullbody,
                2,
                true,
                "Me and Junpei having a picnic",
                DateTime.Today.AddDays(7));

            var request = new CommissionRequest(
                client,
                commission);

            CommissionRepository.AddCommission(request);

            var queue = new CommissionQueue();

            queue.LoadFromDatabase();

            Assert.AreEqual(1, queue.Count);
            Assert.AreEqual(
                "Yuji",
                queue.Commissions[0].Client.ClientName);
        }

    }
}
