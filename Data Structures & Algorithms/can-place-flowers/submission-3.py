class Solution:
    def canPlaceFlowers(self, flowerbed: List[int], n: int) -> bool:
        prev = -1
        next = 1
        curr = 0
        count = 0
        while (curr != len(flowerbed)-1):
            if flowerbed[curr] == 0 and flowerbed[next] != 1 and flowerbed[prev] != 1:
                count+=1
                flowerbed[curr] = 1
            next+=1
            curr+=1
            prev+=1
        if flowerbed[curr] == 0 and flowerbed[prev] != 1:
            count+=1
        
        return count >= n

                