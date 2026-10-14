public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        // key here is to sort the string key alphabetically

        var groups = new Dictionary<string, List<string>>();

        foreach (string str in strs) {
            var sortedKey = string.Concat(str.OrderBy(c => c));

            if (!groups.TryGetValue(sortedKey, out var list)) {
                list = new List<string>();
                groups[sortedKey] = list;
            }
            list.Add(str);
        }

        return groups.Values.ToList();
    }
}
