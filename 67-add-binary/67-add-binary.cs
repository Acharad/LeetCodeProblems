public class Solution 
{
    public string AddBinary(string a, string b) 
    {
        int aLen = a.Length - 1;
        int bLen = b.Length - 1;
        // we need carry for 10, 10 = 100
        int carry = 0;
        StringBuilder strB = new StringBuilder();
        
        while(aLen >= 0 || bLen >= 0 || carry == 1)
        {
            int aVal = aLen < 0 ? 0 : Convert.ToInt32(char.GetNumericValue(a[aLen]));
            int bVal = bLen < 0 ? 0 : Convert.ToInt32(char.GetNumericValue(b[bLen]));
            
            int currentVal = aVal + bVal + carry;
            strB.Insert(0, currentVal % 2);
            carry = currentVal / 2;
            
            
            aLen--;
            bLen--;
        }
        
        return strB.ToString();
    }
}