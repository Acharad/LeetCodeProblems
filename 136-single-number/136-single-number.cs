public class Solution 
{
    public int SingleNumber(int[] nums) 
    {
        int value = 0;
        for(int i = 0;i < nums.Length; i++)
        {
            value ^= nums[i];
        }
        return value;
    }
}