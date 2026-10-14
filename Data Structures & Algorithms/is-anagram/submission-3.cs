public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;


        var sums = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++) {
            var c1 = s[i];
            var c2 = t[i];

            sums.TryAdd(c1, 0);
            sums.TryAdd(c2, 0);

            sums[c1] -= 1;
            sums[c2] += 1;
        }

        return sums.Values.ToList().All(x => x == 0);
    }
}
