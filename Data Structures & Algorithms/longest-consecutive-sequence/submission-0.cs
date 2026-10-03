public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = nums.ToHashSet();
        var maxRun = 0;

        for (int i = 0; i < nums.Length; i++) {
            var num = nums[i];
            var run = 1;

            if (set.Contains(num - 1)) {
                continue;
            }

            var nextNum = num + 1;
            while (set.Contains(nextNum)) {
                run++;
                nextNum++;
            }

            if (run > maxRun) {
                maxRun = run;
            }
        }

        return maxRun;
    }
}
