/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution 
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) 
    {
        var ans = new HashSet<ListNode>();
        
        while(headA != null)
        {
            ans.Add(headA);
            headA = headA.next;
        }
        
        while(headB != null)
        {
            if(ans.Contains(headB))
                return headB;
            
            headB = headB.next;
        }
        
        return null;   
    }
}