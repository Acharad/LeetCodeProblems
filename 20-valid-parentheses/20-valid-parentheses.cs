public class Solution 
{
    public bool IsValid(string s) 
    {
        var stack = new Stack<char>();
        
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                stack.Push(s[i]);
                continue;
            }
            
            if(stack.Count == 0)
            {
                stack.Push(s[i]);
                break;
            }
            
            //s[i] '(' olduğu zaman stack'in içinde olan en üstteki char ')' değilse false döndürmemiz lazım bü yüzden eşit olmayana bakıyoruz.
            Console.WriteLine(s[i]);
            Console.WriteLine(stack.Peek());
            if(s[i] == ')' && stack.Peek() != '(')
                break;
            if(s[i] == '}' && stack.Peek() != '{')
                break;
            if(s[i] == ']' && stack.Peek() != '[')
                break;
            //
            stack.Pop();            
        }
        
        if(stack.Count > 0)
            return false;
        else
            return true;
    }
}