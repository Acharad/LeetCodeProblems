public class Solution 
{
    public int RemoveElement(int[] nums, int val) 
    {
        int counter = 0;
        int a = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(i);
            
            if(nums[i] == val)
            {
                Console.WriteLine("son eleman " + nums[nums.Length - 1 - a]);
                nums[i] = nums[nums.Length - 1 - a];
                nums[nums.Length - 1 - a] = -1;
                a++;
                i--;
            }
        }
        return nums.Length - a;
    }
}