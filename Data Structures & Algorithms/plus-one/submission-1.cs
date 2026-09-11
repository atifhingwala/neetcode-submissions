public class Solution {
    public int[] PlusOne(int[] digits) {
        string[] digitStr = digits.Select(x=> x.ToString()).ToArray();
        string digit = string.Join("", digitStr);
        ulong digitNum = ulong.Parse(digit) + 1;
        return digitNum.ToString().Select(x => int.Parse(x.ToString())).ToArray();
    }
}
