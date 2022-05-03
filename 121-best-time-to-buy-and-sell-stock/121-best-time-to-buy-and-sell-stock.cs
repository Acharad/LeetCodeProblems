public class Solution 
{
    public int MaxProfit(int[] prices) 
    {
        // almak b, satmak s
        // alma olmadan satma olamaz o yüzden if else if olcak
        // aldıktan sonra daha düşük bir alma noktası gelmeyene kadar price hesaplanacak
        // daha yüksek bir price gelmeyene kadar eski price geçerli olacak.
        
        // gerekli olan değerler b, currentprice, maxprice.
        int b = Int32.MaxValue, cPrice = 0, maxPrice;

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