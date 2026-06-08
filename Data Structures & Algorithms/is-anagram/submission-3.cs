public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }
        Dictionary<char, string> hashS = new Dictionary<char, string>();
        Dictionary<char, string> hashT = new Dictionary<char, string>();
        for (int i = 0; i < s.Length; i++)
        {
            hashS[s[i]] = hashS.GetValueOrDefault(s[i]) + 1;
            hashT[t[i]] = hashT.GetValueOrDefault(t[i]) + 1;
        }

        return hashS.Count() == hashT.Count() && !hashT.Except(hashS).Any();
    }
}
