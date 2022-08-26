/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution 
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        int sum = 0;
        ListNode newNode = new ListNode();
        ListNode ans = newNode;
        
        while (l1 != null || l2 != null || sum != 0)
        {
            newNode.next = new ListNode();
            newNode = newNode.next;
            
            if(l1 != null)
            {
                sum += l1.val;
                l1 = l1.next;
            }
                
            
            if(l2 != null)
            {
                sum += l2.val;
                l2 = l2.next;
            }
                
            newNode.val = sum % 10;

            sum /= 10;
        }
        
        return ans.next;
    }
}