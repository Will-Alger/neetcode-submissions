public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var seen = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            var current = nums[i];
            var pair = target - current;

            if (seen.TryGetValue(pair, out var pairIndex)) {
                return [pairIndex, i];
            }

            seen[current] = i;
        }
        return [];
    }
}
