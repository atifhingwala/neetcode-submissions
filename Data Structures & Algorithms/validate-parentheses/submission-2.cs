public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        Dictionary<char,char> braces = new Dictionary<char,char>()
        {
            { ')' , '(' },
            { ']' , '[' },
            { '}' , '{' }
        };

        foreach (char c in s)
        {
            if (braces.ContainsKey(c))
            {
                if (stack.Count > 0 && stack.Pop() == braces[c])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                stack.Push(c);
            }
        }

        return stack.Count() == 0;
    }
}
