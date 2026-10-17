using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using ArtCommissionApplication_Prototype;
using static ArtCommissionApplication_Prototype.CommissionInformation;

namespace ArtCommisionApplication.Test
{
    [TestClass]
    public class QualityStatisticsTests
    {
        private string testDbPath = string.Empty;

        [TestInitialize]
        public void Init()
        {
            SessionManager.Logout();
            testDbPath = Path.Combine(Path.GetTempPath(), $"QualityStats_{Guid.NewGuid()}.db");
            CommissionRepository.Initialize(testDbPath);
        }

        [TestCleanup]
        public void Cleanup()
        {
            SessionManager.Logout();
            try { File.Delete(testDbPath); } catch { }
        }

        [TestMethod]
        public void TypeStatistics_IncludesAllTypesAndPercentagesAndTotals()
        {
            var client = new Client("A","a@example.com");

            var h1 = new CommissionRequest(client, new CommissionInformation(CharacterCrop.Headshot, 1, false, "h1", DateTime.Today.AddDays(7)));
            CommissionRepository.AddCommission(h1);

            var h2 = new CommissionRequest(client, new CommissionInformation(CharacterCrop.Headshot, 2, true, "h2", DateTime.Today.AddDays(7)));
            CommissionRepository.AddCommission(h2);

            var half = new CommissionRequest(client, new CommissionInformation(CharacterCrop.Halfbody, 1, false, "hb", DateTime.Today.AddDays(7)));
            CommissionRepository.AddCommission(half);

            var full = new CommissionRequest(client, new CommissionInformation(CharacterCrop.Fullbody, 3, true, "fb", DateTime.Today.AddDays(7)));
            CommissionRepository.AddCommission(full);

            var res = QualityStatisticsService.CalculateTypeStatistics();

            Assert.AreEqual(4, res.TotalCount);

            // Find each type
            var head = res.Items.Find(i => i.CropType == CharacterCrop.Headshot);
            var halfs = res.Items.Find(i => i.CropType == CharacterCrop.Halfbody);
            var fulls = res.Items.Find(i => i.CropType == CharacterCrop.Fullbody);

            Assert.IsNotNull(head);
            Assert.IsNotNull(halfs);
            Assert.IsNotNull(fulls);

            Assert.AreEqual(2, head.Count);
            Assert.AreEqual(1, halfs.Count);
            Assert.AreEqual(1, fulls.Count);

            // Percentages must sum to approximately 100
            var sumPercent = head.PercentageOfTotal + halfs.PercentageOfTotal + fulls.PercentageOfTotal;
            Assert.IsTrue(Math.Abs(sumPercent - 100.0) < 0.001 || Math.Abs(sumPercent) < 0.001);

            // Base prices
            Assert.AreEqual(30m, head.BasePrice);
            Assert.AreEqual(50m, halfs.BasePrice);
            Assert.AreEqual(60m, fulls.BasePrice);

            // Total estimated prices should reflect stored EstimatedPrice
            Assert.AreEqual(h1.CommissionType.EstimatedPrice + h2.CommissionType.EstimatedPrice, head.TotalEstimatedPrice);
            Assert.AreEqual(half.CommissionType.EstimatedPrice, halfs.TotalEstimatedPrice);
            Assert.AreEqual(full.CommissionType.EstimatedPrice, fulls.TotalEstimatedPrice);
        }

        [TestMethod]
        public void YearlyVolume_IncludesZeroMonthsAndMultipleYears()
        {
            var client = new Client("A","a@example.com");

            // Create commissions across different months and years
            var r1 = new CommissionRequest(client, new CommissionInformation(CharacterCrop.Headshot, 1, false, "r1", DateTime.Today.AddDays(7)));
            CommissionRepository.AddCommission(r1);
            // manipulate submitted dates via direct DB update for test determinism
            var dt1 = new DateTime(2023, 1, 5);
            using (var conn = new Microsoft.Data.Sqlite.SqliteConnection($"Data Source={testDbPath}"))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Commissions SET SubmittedDate = $s WHERE Id = $id;";
                cmd.Parameters.AddWithValue("$s", dt1.ToString("o"));
                cmd.Parameters.AddWithValue("$id", r1.Id);
                cmd.ExecuteNonQuery();
            }

            var r2 = new CommissionRequest(client, new CommissionInformation(CharacterCrop.Headshot, 1, false, "r2", DateTime.Today.AddDays(7)));
            CommissionRepository.AddCommission(r2);
            var dt2 = new DateTime(2023, 12, 15);
            using (var conn = new Microsoft.Data.Sqlite.SqliteConnection($"Data Source={testDbPath}"))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Commissions SET SubmittedDate = $s WHERE Id = $id;";
                cmd.Parameters.AddWithValue("$s", dt2.ToString("o"));
                cmd.Parameters.AddWithValue("$id", r2.Id);
                cmd.ExecuteNonQuery();
            }

            var r3 = new CommissionRequest(client, new CommissionInformation(CharacterCrop.Headshot, 1, false, "r3", DateTime.Today.AddDays(7)));
            CommissionRepository.AddCommission(r3);
            var dt3 = new DateTime(2024, 6, 10);
            using (var conn = new Microsoft.Data.Sqlite.SqliteConnection($"Data Source={testDbPath}"))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Commissions SET SubmittedDate = $s WHERE Id = $id;";
                cmd.Parameters.AddWithValue("$s", dt3.ToString("o"));
                cmd.Parameters.AddWithValue("$id", r3.Id);
                cmd.ExecuteNonQuery();
            }

            var res = QualityStatisticsService.CalculateYearlyVolume();

            Assert.IsTrue(res.Series.Exists(s => s.Year == 2023));
            Assert.IsTrue(res.Series.Exists(s => s.Year == 2024));

            var s2023 = res.Series.Find(s => s.Year == 2023);
            Assert.AreEqual(12, s2023.MonthlyCounts.Length);
            Assert.AreEqual(1, s2023.MonthlyCounts[0]); // January
            Assert.AreEqual(1, s2023.MonthlyCounts[11]); // December

            var s2024 = res.Series.Find(s => s.Year == 2024);
            Assert.AreEqual(12, s2024.MonthlyCounts.Length);
            Assert.AreEqual(1, s2024.MonthlyCounts[5]); // June
        }
    }
}
