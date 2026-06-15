public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        for (int i = 0; i < numbers.Length; i++)
        {
            int num = target - numbers[i];
            int index = Array.IndexOf(numbers, num);
            if (index != -1)
            {
                return new int[] {i+1, index+1};
            }
        }

        return new int[2];
    }
}
