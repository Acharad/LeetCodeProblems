public class Solution {
    public bool IsPalindrome(int x) 
    {
        
        int mainX = x;
        int xDigitCount;
        int xDigit;
        int xDigitPow = 1;
        int TotalPow;
        
        int palindrome = 0; 
        
        int digitNumber;
        
        bool isTrue = false;
        
        
        
        //Let's find the number of digits in x
        
        xDigitCount = (int)Math.Floor(Math.Log10(x)) + 1;   
        
        for(int i = 1 ; i < xDigitCount; i++)
        {
            xDigitPow = xDigitPow * 10;
            //xDigitPow = (int)Mathf.Pow(10,xDigitCount - i);
        }
        
        for(int i = 0;i < xDigitCount; i++)
        {
        	xDigit = x%10;
            xDigit = xDigit * xDigitPow;
            palindrome = palindrome + xDigit;
            x = x/10; 
            xDigitPow = xDigitPow/10;
        }
        if(mainX == palindrome)
        {
        	isTrue = true;
            return isTrue;
        }
        return isTrue;
    }
}
