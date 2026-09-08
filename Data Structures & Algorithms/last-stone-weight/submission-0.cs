public class Solution {
    public int LastStoneWeight(int[] stones) {
        List<int> stonesList = new List<int>(stones);
        while (stonesList.Count > 1)
        {
            stonesList = stonesList.OrderByDescending(x => x).ToList();
            stonesList.Add(Math.Abs(stonesList[0] - stonesList[1]));
            stonesList.RemoveAt(0);
            stonesList.RemoveAt(0);
        }

        return stonesList[0];
    }
}
