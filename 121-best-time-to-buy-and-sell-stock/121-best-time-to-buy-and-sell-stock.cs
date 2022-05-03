public class Solution 
{
    public int MaxProfit(int[] prices) 
    {
        int b = Int32.MaxValue, cPrice = 0;

        for(int i = 0;i < prices.Length; i++)
        {
            if(b > prices[i])
                b = prices[i];
            else if(prices[i] - b > cPrice)
                cPrice = prices[i] - b;
        }
        if(cPrice != 0)
            return cPrice;
        return cPrice;
    }
}