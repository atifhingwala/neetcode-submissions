class Solution:
    def canConstruct(self, ransomNote: str, magazine: str) -> bool:
        ransomCount = Counter(ransomNote)
        magazineCount = Counter(magazine)

        return ransomCount <= magazineCount