public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();
        foreach(string s in strs) {
           sb.Append($"{s.Length}#{s}");
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
        int i = 0;
        while (i < s.Length) {
            var idx = s.IndexOf('#', i);
            var len = int.Parse(s.Substring(i, idx - i));
            var str = s.Substring(idx + 1, len);
            result.Add(str);
            i = idx + 1 + len;
        }

        return result;
   }
}
