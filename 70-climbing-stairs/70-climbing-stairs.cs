public class Solution 
{
    public int ClimbStairs(int n) 
    {
        int first  = 1;     
        int second = 2;     
        int tmp = 0;        
        
        if(n<=2) return n;
        
        for(int i = 3; i<=n; i++) 
        {
            tmp = second;       
            second += first; 
            first = tmp;       
        }
        return second;
    }
}