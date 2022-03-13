public class Solution 
{
    public int RemoveDuplicates(int[] nums) 
    {
        int k = 0;
        //[0,0,1,1,1,2,2,3,3,4] - [1,1,2]
        // ilk indexi incelemeye gerek yok.Çünkü veirlen nums dizisi zaten sıralanmış olarak verildiği için ilk eleman kaçtan başlarsa başlasın doğru yerde olmuş olacak.
        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[k] != nums[i])
            {
                k++;
                nums[k] = nums[i];
            }
        }
        return ++k;
    }
}