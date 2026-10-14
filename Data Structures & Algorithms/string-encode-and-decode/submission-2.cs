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

        // pointer
        int i = 0;

        // while pointer is not at end of the string
        while (i < s.Length) {
            // get index of # starting at i
            var idx = s.IndexOf('#', i);

            // get the length of the string
            var len = int.Parse(s.Substring(i, idx - i));

            // get the string
            var str = s.Substring(idx + 1, len);

            // add the string
            result.Add(str);

            // set the new pointer to the first char after #<string>
            i = idx + len + 1;
        }

        return result;
   }
}
