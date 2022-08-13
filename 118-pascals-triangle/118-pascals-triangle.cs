public class Solution 
{
    public IList<IList<int>> Generate(int numRows) 
    {
        List<IList<int>> ans = new List<IList<int>>() { new List<int>() { 1 } };
        
        if (numRows == 1) return ans;
        
        for(int i = 0; i < numRows - 1; i++)
        {
            // every row starts with 1 
            List<int> row = new List<int>() { 1 };
            
            IList<int> lastRow = ans[ans.Count - 1];
        
            for(int j = 0; j < ans.Count - 1; j++)
            {
                row.Add(lastRow[j] + lastRow[j + 1]);
            }
            
            // every row ends with 1
            row.Add(1);
            ans.Add(row);
        }
        
        return ans;
    }
}