public class Solution 
{
    public int[] Shuffle(int[] nums, int n) 
    {
        // x1,x2,x3,y1,y2,y3
        // x1,y1,x2,y2,x3,y3
        List<int> ans = new List<int>();
        for(var i = 0; i < n; i++)
        {
            ans.Add(nums[i]);
            ans.Add(nums[n+i]);
        }
        
        return ans.ToArray();
    }
}