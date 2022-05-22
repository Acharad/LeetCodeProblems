public class Solution 
{
    public int MinBitFlips(int start, int goal) 
    {
        return System.Numerics.BitOperations.PopCount( (uint)(start ^ goal) );
    }
}