#region MiddleNode

//    public class SolutionWeek02
//    {

//        //Example 1:
//        //Input: head = [1, 2, 3, 4, 5]
//        //Output: [3, 4, 5]
//        //Explanation: The middle node of the list is node 3.

//        //Example 2:
//        //Input: head = [1, 2, 3, 4, 5, 6] 
//        //Output: [4, 5, 6] 
//        //Explanation: Since the list has two middle nodes with values 3 and 4, we return the second one.

//        //public ListNode MiddleNode(ListNode head)
//        //{
//        //    ListNode current = head;
//        //    int count = 0;
//        //    while (current != null)
//        //    {
//        //        count++;
//        //        current = current.next;
//        //    }

//        //    current = head;
//        //    for (int i = 0; i < count / 2; i++)
//        //    {
//        //        current = current.next;
//        //    }
//        //    return current;

//        //}
//    }
//} 
#endregion

#region ReverseList

//public class SolutionWeek02
//{

//    //Example 1:
//    //Input: head = [1, 2, 3, 4, 5]
//    //Output: [5, 4, 3, 2, 1]

//    //Example 2:
//    //Input: head = [1, 2]
//    //Output: [2, 1]

//    //Example 3:
//    //Input: head = []
//    //Output: []

//    //public ListNode ReverseList(ListNode head) // [1, 2, 3, 4, 5]
//    //{                                          //           c               
//    //    ListNode currNode = head;              //           n  
//    //    ListNode nextNode = null;            //          p
//    //    ListNode prevNode = null;

//    //    while (currNode != null)
//    //    {
//    //        nextNode = currNode.next;
//    //        currNode.next = prevNode;
//    //        prevNode = currNode;
//    //        currNode = nextNode;
//    //    }

//    //    return prevNode;

//    //}
//}

#endregion

#region MergeTwoLists
//public class SolutionWeek02
//{
//    //Example 1:
//    //Input: list1 = [1, 2, 4], list2 = [1, 3, 4]
//    //Output: [1, 1, 2, 3, 4, 4]

//    //Example 2:
//    //Input: list1 = [], list2 = []
//    //Output: []

//    //Example 3:
//    //Input: list1 = [], list2 = [0]
//    //Output: [0]
//    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
//    {
//        ListNode dummy = new(-1);
//        ListNode tail = dummy;
//        while (list1 != null && list2 != null)
//        {
//            if (list1.val <= list2.val)
//            {
//                tail.next = list1;
//                list1 = list1.next;
//            }
//            else
//            {
//                tail.next = list2;
//                list2 = list2.next;
//            }
//            tail = tail.next;
//        }
//        tail.next = list1 ?? list2;
//        return dummy.next;
//    }
//} 
#endregion
