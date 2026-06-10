public class Solution {
    public int AppendCharacters(string s, string t) {
        int startT = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (t[startT] == s[i])
            {
                startT++;
            }
            if (startT == t.Length)
            {
                return 0;
            }
        }

        return t.Length - startT;
    }
}