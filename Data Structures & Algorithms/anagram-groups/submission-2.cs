public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> res = new Dictionary<string, List<string>>();
        for (int i = 0; i < strs.Length; i++)
        {
            char[] s = strs[i].ToCharArray();
            Array.Sort(s);
            string sortedS = new string(s);
            if (res.ContainsKey(sortedS))
            {
                res[sortedS].Add(strs[i]);
            }
            else
            {
                res[sortedS] = new List<string>{strs[i]};
            }
        }

        return res.Values.ToList<List<string>>();
    }
}
