
#region List Node
//public class ListNode
//{
//    public int val;
//    public ListNode next;
//    public ListNode(int val = 0, ListNode next = null)
//    {
//        this.val = val;
//        this.next = next;
//    }
//}
#endregion

#region HasCycle
//internal class SolutionWeek03
//{
//    //    //Example 1:
//    //    //Input: head = [3, 2, 0, -4], pos = 1
//    //    //Output: true
//    //    //Explanation: There is a cycle in the linked list, where the tail connects to the 1st node(0-indexed).

//    //    //Example 2:
//    //    //Input: head = [1, 2], pos = 0
//    //    //Output: true
//    //    //Explanation: There is a cycle in the linked list, where the tail connects to the 0th node.

//    //    //Example 3:
//    //    //Input: head = [1], pos = -1
//    //    //Output: false
//    //    //Explanation: There is no cycle in the linked list.


//    public bool HasCycle(ListNode head)
//    {
//        if (head == null || head.next == null) return false;
//        ListNode slow = head;
//        ListNode fast = head;
//        while (fast != null && fast.next != null)
//        {
//            slow = slow.next;
//            fast = fast.next.next;
//            if (slow == fast) return true;
//        }
//        return false;
//    }
//} 
#endregion

#region IsPalindrome

//public class SolutionWeek03
//{

//    //Example 1:
//    //Input: head = [1, 2, 2, 1]
//    //Output: true

//    //Example 2:
//    //Input: head = [1, 2]
//    //Output: false

//    public bool IsPalindrome(ListNode head) // 1  2  2  1
//    {
//        var beginNum = 0;  // → 1 → 2 → 2 → 1
//        var endNum = 0;    // 1 ← 2 ← 2 ← 1 ←
//        var mul = 1;
//        while (head != null)
//        {
//            beginNum = (beginNum * 10) + head.val;   
//            endNum = endNum + (head.val * mul);      
//            mul *= 10;                               
//            head = head.next;                        
//        }
//        return beginNum == endNum;
//    }
//} 
#endregion


