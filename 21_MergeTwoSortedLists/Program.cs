
using System.Reflection.Metadata.Ecma335;

namespace MergeTwoSortedLists;

public class Program
{
    public static void Main()
    {

    }

    public static ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        ListNode head = new ListNode(-1);
        ListNode current = head;
        
        while(list1 != null & list2 != null)
        {
            if(list1.val <= list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }
        
        if(list1 != null)
            current.next = list1;
        else
            current.next = list2;

        return head.next;
    }

    public static ListNode MergeTwoLists_Recursive(ListNode list1, ListNode list2)
    {
        if(list1 == null) return list2;
        if(list2 == null) return list1;

        if(list1.val <= list2.val)
        {
            list1.next = MergeTwoLists_Recursive(list1.next, list2);
            return list1;
        }
        else
        {
            list2.next = MergeTwoLists_Recursive(list1, list2.next);
            return list2;
        }
    }
}