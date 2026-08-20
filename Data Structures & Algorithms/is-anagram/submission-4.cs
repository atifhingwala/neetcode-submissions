public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] sArr = s.ToCharArray();
        Array.Sort(sArr);
        char[] tArr = t.ToCharArray();
        Array.Sort(tArr);

        if (new String(sArr) ==new String(tArr))
        {
            return true;
        }

        return false;
    }
}
