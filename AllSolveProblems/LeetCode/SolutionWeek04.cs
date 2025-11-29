

#region 203. Remove Linked List Elements
//Input: head = [1, 2, 6, 3, 4, 5, 6], val = 6
//Output: [1, 2, 3, 4, 5]

//Example 2:
//Input: head = [], val = 1
//Output: []

//Example 3:
//Input: head = [7, 7, 7, 7], val = 7
//Output: []
//public class SolutionWeek04
//{
//    public ListNode RemoveElements(ListNode head, int val)
//    {
//        ListNode dummy = new(0);
//        dummy.next = head;
//        ListNode curr = head;
//        ListNode prev = dummy;

//        while (curr != null)
//        {
//            if (curr.val == val)
//            {
//                prev.next = curr.next;
//            }
//            else
//            {
//                prev = curr;
//            }
//            curr = curr.next;
//        }
//        return dummy.next;
//    }
//} 
#endregion


#region 160. Intersection of Two Linked Lists
//Example 1:
//Input: intersectVal = 8, listA = [4,1,8,4,5], listB = [5,6,1,8,4,5], skipA = 2, skipB = 3
//Output: Intersected at '8'

//Example 2:
//Input: intersectVal = 2, listA = [1,9,1,2,4], listB = [3,2,4], skipA = 3, skipB = 1
//Output: Intersected at '2'

//Example 3:
//Input: intersectVal = 0, listA = [2,6,4], listB = [1,5], skipA = 3, skipB = 2
//Output: No intersection

//public class SolutionWeek04 // Two Pointers Technique
//{
//    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
//    {
//        if (headA == null || headB == null) return null;

//        ListNode a = headA; // 4 1 8 4 5 5 6 1 8 4 5
//        ListNode b = headB; // 5 6 1 8 4 5 4 1 8 4 5

//        while (a != b)
//        {
//            a = (a == null) ? headB : a.next;
//            b = (b == null) ? headA : b.next;
//        }

//        return a;
//    }
//}
#endregion


#region 61. Rotate List
// Example 1:
//Input: head = [1,2,3,4,5], k = 2
//Output: [4, 5, 1, 2, 3]

//Example 2:
//Input: head = [0, 1, 2], k = 4
//Output: [2, 0, 1]
//public class SolutionWeek04
//{
//    public ListNode RotateRight(ListNode head, int k) // [1,2,3,4,5] , k = 2
//    {
//        if (head == null || head.next == null || k == 0) return head;

//        ListNode curr = head;
//        int count = 0;
//        while (curr != null)
//        {
//            count++;
//            curr = curr.next;
//        } // count = 5

//        k %= count; // k = 2 % 5 = 2
//        if (k == 0) return head;

//        ListNode fast = head;
//        ListNode slow = head;

//        for (int i = 0; i < k; i++)
//        {
//            fast = fast.next;
//        }// 3 4 5
//        // fast 3 4 5
//        // slow 1 2 3
//        while (fast.next != null)
//        {
//            fast = fast.next;
//            slow = slow.next;
//        }
//        ListNode newNode = slow.next; // 4 5
//        slow.next = null;
//        fast.next = head; // 1 2 3
//        return newNode; // 4 5 1 2 3
//    }
//}
#endregion
