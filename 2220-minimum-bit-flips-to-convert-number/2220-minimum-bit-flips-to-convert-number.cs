public class Solution 
{
    public int MinBitFlips(int start, int goal) 
    {
        string startBinaryForm = Convert.ToString(start, 2);
        string goalBinaryForm = Convert.ToString(goal, 2);
        int counter = 0;
        int i;
        int lengthS = startBinaryForm.Length - goalBinaryForm.Length;
        int lengthG = goalBinaryForm.Length - startBinaryForm.Length;
        for(i = 0; i < lengthS; i++)
        {
            goalBinaryForm = "0" + goalBinaryForm;
        }
        Console.WriteLine(i);
        for(i = 0; i < lengthG; i++)
        {
            startBinaryForm = "0" + startBinaryForm;
        }
        
        for(i = 0; i < goalBinaryForm.Length; i++)
        {
            if(startBinaryForm[i] != goalBinaryForm[i])
            {
                counter++;
                Console.WriteLine("c =" + counter);
            }
        }
        return counter;
    }
}