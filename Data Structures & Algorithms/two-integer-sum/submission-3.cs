public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // goal find the matching value
        var seen = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            var val = nums[i];
            var comp = target - val;

            if (seen.TryGetValue(comp, out var compIndex)) {
                return [compIndex, i];
            }

            seen[val] = i;
        }

        return [];
    }
}
