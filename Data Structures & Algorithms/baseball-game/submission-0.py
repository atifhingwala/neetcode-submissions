class Solution:
    def calPoints(self, operations: List[str]) -> int:
        stack = []
        for c in operations:
            match c:
                case '+':
                    a,b = stack[-2:]
                    stack.append(int(a) + int(b))
                    continue
                case 'D':
                    stack.append(int(stack[-1]) * 2)
                    continue
                case 'C':
                    stack.pop()
                    continue
            stack.append(int(c))
        
        return sum(stack)