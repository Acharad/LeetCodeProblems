public class Solution 
{
    public int SearchInsert(int[] nums, int target) 
    {
        int currentNums = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == target)
                return i;
            else if(target > nums[i])
            {
                currentNums = i+1;
            }
        }
        return currentNums;
    }
}