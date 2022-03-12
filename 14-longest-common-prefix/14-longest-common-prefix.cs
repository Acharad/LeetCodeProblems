public class Solution 
{
    public string LongestCommonPrefix(string[] strs) 
    {
        if(strs.Length == 0)
            return "";
        
        var prefix = strs[0];
        for(int i = 1; i < strs.Length; i++)
        {
            // strs i içinde prefix varsa 0 döner yoksa - 1 döner
            // prefix boş olduğu zaman 0 dönecek ve boş string return edicez
            while(strs[i].IndexOf(prefix) != 0)
            {
                // eğer prefix bulamadıysak prefixi azaltıp tekrardan bakıyoruz
                prefix = prefix.Substring(0, prefix.Length - 1);
            }
        }
        return prefix;
    }
}