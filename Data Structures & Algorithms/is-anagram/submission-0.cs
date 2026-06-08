public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] sArr = s.ToCharArray();
        Array.Sort(sArr);
        string sortedS = string.Join("", sArr);
        char[] tArr = t.ToCharArray();
        Array.Sort(tArr);
        string sortedT = string.Join("", tArr);

        if (sortedT == sortedS)
        {
            return true;
        }

        return false;
    }
}
