using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoSumApp;

namespace TwoSumApp.Tests
{
    [TestClass]
    public class TwoSumTests
    {
        [TestMethod]
        public void TwoSum_BasicCase_ReturnsCorrectIndices()
        {
            var solution = new Solution();

            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            var result = solution.TwoSum(nums, target);

            CollectionAssert.AreEqual(new int[] { 0, 1 }, result);
        }

        [TestMethod]
        public void TwoSum_AnotherCase_ReturnsCorrectIndices()
        {
            var solution = new Solution();

            int[] nums = { 3, 2, 4 };
            int target = 6;

            var result = solution.TwoSum(nums, target);

            CollectionAssert.AreEqual(new int[] { 1, 2 }, result);
        }

        [TestMethod]
        public void TwoSum_WithDuplicates()
        {
            var solution = new Solution();

            int[] nums = { 3, 3 };
            int target = 6;

            var result = solution.TwoSum(nums, target);

            CollectionAssert.AreEqual(new int[] { 0, 1 }, result);
        }
    }
}