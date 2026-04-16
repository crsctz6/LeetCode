namespace TwoSumApp
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }

                map[nums[i]] = i;
            }

            return new int[] { };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            var result = solution.TwoSum(nums, target);

            Console.WriteLine($"[{result[0]}, {result[1]}]");
        }
    }
}