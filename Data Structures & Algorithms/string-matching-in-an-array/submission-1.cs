public class Solution {
    public List<string> StringMatching(string[] words) {
        List<string> wordArr = new List<string>();
        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < words.Length; j++)
            {
                if (j==i) continue;
                bool isSubsequence = isSubstring(words[i], words[j]);
                if (isSubsequence)
                {
                    wordArr.Add(words[i]);
                    break;
                }
            }
        }

        return wordArr;
    }

    private bool isSubstring(string s, string t)
    {
        if (t.Contains(s))
        {
            return true;
        }

        return false;
    }
}