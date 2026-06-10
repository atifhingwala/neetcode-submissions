public class Solution {
    public bool IsSubsequence(string s, string t) {
        if (s.Length == 0) return true;
        int startS = 0;
        for (int i = 0; i < t.Length; i++)
        {
            if (t[i] == s[startS])
            {
                startS++;
            }
            if (startS == s.Length)
            {
                return true;
            }
        }

        return false;
    }
}