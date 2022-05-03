public class Solution 
{
    public void Merge(int[] nums1, int m, int[] nums2, int n) 
    {
        int i;
        int k = 0,j = 0;
        
        var newArr = new int[m+n];
        
        for(i = 0;k < m && j < n; i++)
        {
            if(nums1[k] < nums2[j])
            {
                newArr[i] = nums1[k];
                k++;
            }
            else
            {
                newArr[i] = nums2[j];
                j++;
            }
        }
        
        for(; k < m; i++, k++)
        {
            newArr[i] = nums1[k];
        }
        
        for(; j < n; i++, j++)
        {
            newArr[i] = nums2[j];
        }
        for(i = 0; i < m+n; i++)
        {
            nums1[i] = newArr[i];
        }
    }
}