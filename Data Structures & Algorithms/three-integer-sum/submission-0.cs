public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<List<int>> triplets = [];

        for (int i = 0; i < nums.Length; i++) {

            if (nums[i] > 0)
                break;
                // because current value is positive, and list is sorted,
                // all next values will be positive too. no three pos vars sum to 0;


            if (i > 0 && nums[i] == nums[i - 1])
                continue; // skip duplicates

            var pairs = TwoSumSorted(nums, i + 1, -nums[i]);
            foreach(var (b, c) in pairs) {
                triplets.Add([nums[i], b, c]);
            }
        }
        return triplets;
    }

    public List<(int, int)> TwoSumSorted(int[] nums, int start, int target) {
        List<(int, int)> pairs = [];
        int left = start, right = nums.Length - 1;

        while (left < right) {
            int sum = nums[left] + nums[right];

            if (sum < target) 
                left++;
            else if (sum > target)
                right--;
            else {
                pairs.Add((nums[left], nums[right]));
                left++;

                while (left < right && nums[left] == nums[left - 1])
                    left++;
            }
        }

        return pairs;
    }
}
