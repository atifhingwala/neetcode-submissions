public class Solution {
    public bool IsValid(string s) {
        while (s!= "")
        {
            if (s.Contains("{}"))
            {
                s = s.Replace("{}", "");
            }   
            else if (s.Contains("[]"))
            {
                s = s.Replace("[]","");
            }  
            else if (s.Contains("()"))
            {
                s= s.Replace("()", "");
            }
            else
            {
                return false;
            }
        }

        if (s== "")
        {
            return true;
        }

        return false;
    }
}
