public class Solution 
{
    public int[] PlusOne(int[] digits) 
    {
        int dL = digits.Length;
        for(int i= dL - 1;i >= 0;i--)
        {
            if(digits[i] == 9)
            {
                digits[i] = 0;
            }
            else
            {
                digits[i] = digits[i] + 1;
                return digits;
            }
        }
        
        int [] arr = new int [dL + 1];
        arr[0] = 1;
        for(int i = 1;i < dL + 1; i++)
        {
            arr[i] = digits[i - 1];
        }
        
        return arr;
    }
}