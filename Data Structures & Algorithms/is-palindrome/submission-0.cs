public class Solution {
    public bool IsPalindrome(string s) {

        // remove white space
        var input = s.Replace(" ", "");

        int left = 0;
        int right = s.Length - 1;

        while (left < right) {
            
            while (left < right && !char.IsLetterOrDigit(s[left])){
                left++;
            }

            while (right > left && !char.IsLetterOrDigit(s[right])){
                right--;
            }

            if (char.ToLower(s[left]) != char.ToLower(s[right])) {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}
