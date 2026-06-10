public class Solution {
    public int LengthOfLastWord(string s) {
        string[] strArr = s.Trim().Split(" ");
        Array.Reverse(strArr);

        return strArr.First().Length;
    }
}