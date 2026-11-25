class Solution:
    def maxArea(self, heights: List[int]) -> int:
        maxArea = 0
        l, r = 0, len(heights)-1
        while l<r:
            h = min(heights[r], heights[l])
            area = h * (r-l)
            maxArea = max(area, maxArea)
            if heights[r] < heights[l]:
                r-=1
            else:
                l+=1
        return maxArea

