class Solution:
    def evalRPN(self, tokens: List[str]) -> int:
        stack = []
        for c in tokens:
                match c:
                    case '+':
                        a = stack.pop()
                        b = stack.pop()
                        stack.append(a+b)
                        continue
                    case '*':
                        a = stack.pop()
                        b = stack.pop()
                        stack.append(a*b)
                        continue
                    case '/':
                        a = stack.pop()
                        b = stack.pop()
                        stack.append(int(b/a))
                        continue
                    case '-':
                        a = stack.pop()
                        b = stack.pop()
                        stack.append(b-a)
                        continue
                    case _:
                        stack.append(int(c))
        
        return stack.pop()



