public class Solution 
{
    public int LengthOfLastWord(string s) 
    {
        //int i = s.Length;
        int counter = 0;
        int maxCount = 0;
        for(int i = 0;i < s.Length; i++)
        {
            if(s[i] == ' ')
            {
                counter = 0;
            }
            else
            {
                counter++;
                maxCount = counter;
                Console.WriteLine(s[i]);
                Console.WriteLine(counter);
            } 
        }
        return maxCount;
    }
}