public class Solution 
{
    public bool IsPalindrome(string s) 
    {
        int i = 0;
        int j = s.Length - 1;
        while(i < j)
        {
            if(!Char.IsLetterOrDigit(s[i]))
            {
                i++;
                continue;
            }
                
            if(!Char.IsLetterOrDigit(s[j]))
            {
                j--;
                continue;
            }
            if(Char.ToLower(s[i]) != Char.ToLower(s[j]))
                return false;
            i++;
            j--;
        }
        return true;
    }
}
