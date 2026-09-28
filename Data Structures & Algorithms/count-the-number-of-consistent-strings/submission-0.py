class Solution:
    def countConsistentStrings(self, allowed: str, words: List[str]) -> int:
        allow = []
        for st in words:
            is_allowed = True
            for s in st:
                if s not in allowed:
                    is_allowed = False
                    break
            if is_allowed:
                allow.append(st)
        
        return len(allow)
                
            


        