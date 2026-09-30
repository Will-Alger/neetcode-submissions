public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // an anagrap is in a group if has all the same letters
        // and the same letter frequencies

        // best way is to just alphabetize the chars in a string
        // all anagrams have the same 'key'
        // append the unique arrangement to a List

        var groups = new Dictionary<string, List<string>>();

        foreach (var str in strs) {
            var key = string.Concat(str.OrderBy(c => c));
            if (!groups.TryGetValue(key, out var group)) {
                group = [];
                groups[key] = group;
            }
            group.Add(str);
        }

        return groups.Values.ToList();
    } 
}
