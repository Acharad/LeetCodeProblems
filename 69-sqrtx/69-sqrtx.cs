public class Solution 
{
    public int MySqrt(int x) 
    {
        long xs = 1;
        while(xs * xs <= x)
        {
                xs++;
        }
        return (int)xs - 1;
    }
}