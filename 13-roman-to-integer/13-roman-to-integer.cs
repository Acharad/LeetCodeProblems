public class Solution 
{
    public int RomanToInt(string s) 
    {
        var romDict = new Dictionary<char, int>();
        romDict.Add('I', 1);
        romDict.Add('V', 5);
        romDict.Add('X', 10);
        romDict.Add('L', 50);
        romDict.Add('C', 100);
        romDict.Add('D', 500);
        romDict.Add('M', 1000);
        // I -> V,X IV 4 - IX 9
        // X -> L,C 
        // C -> D,M
         
        int result = 0;
        bool controlPrevRoman = false;
        
        for(int i = s.Length - 1;i >= 0; i--)
        {
            if(controlPrevRoman)
            {
                controlPrevRoman = false;
                continue;
            }
                
            var currentRomanChar = s[i];
            var preRomanChar = ' ';
            if(i == 0)
                preRomanChar = ' ';
            else
                preRomanChar = s[i - 1];
           
            // I -> V,X IV 4 - IX 9
            if((currentRomanChar == 'V' || currentRomanChar == 'X') && preRomanChar == 'I')
            {
                result +=  romDict[currentRomanChar] - romDict[preRomanChar];
                controlPrevRoman = true;
                continue;
            }
            // X -> L,C
            if((currentRomanChar == 'L' || currentRomanChar == 'C') && preRomanChar == 'X')
            {
                result +=  romDict[currentRomanChar] - romDict[preRomanChar];
                controlPrevRoman = true;
                continue;
            }
            // C -> D,M
            if((currentRomanChar == 'D' || currentRomanChar == 'M') && preRomanChar == 'C')
            {
                result +=  romDict[currentRomanChar] - romDict[preRomanChar];
                controlPrevRoman = true;
                continue;
            }
            // result without preRoman
            result += romDict[currentRomanChar];
        }
        return result;
    }
}
    
