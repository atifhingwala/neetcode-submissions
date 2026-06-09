public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int[] ans = new int[arr.Length];
        int rightMax = -1;

        for (int i = arr.Length - 1; i >=0; i--)
        {
            ans[i] = rightMax;
            rightMax = Math.Max(rightMax, arr[i]);
        }

        return ans;
    }
}