public class Solution 
{
    public int MaxSubArray(int[] nums) 
    {
        int sum = int.MinValue;
        int csum = 0;
        for(int i = 0;i < nums.Length; i++)
        {
            csum = csum + nums[i];
            if(csum > sum)
                sum = csum;
            if(csum < 0)
                csum = 0;
        }
        return sum;
    }
}