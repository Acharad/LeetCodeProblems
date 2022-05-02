public class Solution 
{
    public int[] SortArrayByParity(int[] nums) 
    {
        int r = nums.Length - 1,l = 0;
        
        while(l < r)
        {
            if(nums[l] % 2 == 0)
                l++;
            else if(nums[r] % 2 == 1)
                r--;
            else
            {
                (nums[l], nums[r]) = (nums[r], nums[l]);
            }   
        }
        return nums;
    }
}