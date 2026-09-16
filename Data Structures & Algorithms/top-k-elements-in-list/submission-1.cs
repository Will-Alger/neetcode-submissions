public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // O(nlogn)
        // return nums.GroupBy(n => n)
        //     .Select(g => new { Value = g.Key, Count = g.Count()})
        //     .OrderByDescending(x => x.Count)
        //     .Take(k)
        //     .Select(x => x.Value)
        //     .ToArray();

        // part 1
        var counts = new Dictionary<int, int>();
        int maxCount = 0;
        foreach(int i in nums) {
            counts[i] = counts.GetValueOrDefault(i) + 1;
            maxCount = Math.Max(maxCount, counts[i]);
        }

        // part 2
        var buckets = new List<int>[nums.Length + 1];
        foreach(var (number, freq) in counts) {
            buckets[freq] ??= new List<int>();
            buckets[freq].Add(number);
        }

        // part 3
        var result = new List<int>();
        for (int i = maxCount; i > 0 && result.Count < k; i--) {
             if (buckets[i] != null)
                result.AddRange(buckets[i].Take(k - result.Count));
        }
        return result.ToArray();
    }
}
