public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var result = new List<int>();
        var len = nums.Length;

        // prefix
        int[] prefix = new int[len];
        for (int i = 0; i < len; i++) {
            if (i == 0)
                prefix[i] = nums[i];
            else
                prefix[i] = prefix[i - 1] * nums[i];
        }

        // postfix
        int[] postfix = new int[len];
        for(int i = len - 1; i >= 0; i--) {
            if (i == len - 1) 
                postfix[i] = nums[i];
            else 
               postfix[i] = postfix[i + 1] * nums[i];
        }

        // calculate answer
        for (int i = 0; i < len; i++) {
            var before = i > 0 ? prefix[i - 1] : 1;
            var after = i < len - 1 ? postfix[i + 1] : 1;
            var calculated = before * after;
            result.Add(calculated);
        }

        return result.ToArray();
    }
}
