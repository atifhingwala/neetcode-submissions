public class Solution {
    public int LengthOfLongestSubstring(string s) {
        List<char> charList = new List<char>();
        int l = 0; int r = 1;
        int maxLen = 0;
        if (s.Length == 0) return 0;
        charList.Add(s[l]);
        while (r < s.Length)
        {
            if (!charList.Contains(s[r]))
            {
                charList.Add(s[r]);
                maxLen = Math.Max((r-l), maxLen);
                r++;
            }
            else
            {
                charList.Remove(s[l]);
                l++;
            }
        }

        return maxLen + 1;
    }
}
