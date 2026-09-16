public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        return nums.GroupBy(n => n)
            .Select(g => new { Value = g.Key, Count = g.Count()})
            .OrderByDescending(x => x.Count)
            .Take(k)
            .Select(x => x.Value)
            .ToArray();
    }
}
