
namespace MergeTwoSortedLists;

public class Program
{
    public static void Main()
    {

    }

    public static ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        ListNode head = list1;   
        ListNode currList1 = list1;
        
        while(currList1.next != null)
        {
            ListNode currList2 = list2;

            while(currList2.next != null)
            {
                if(currList2.val >= currList1.val)
                {

                }
                currList2 = currList2.next;
            }
            currList1 = currList1.next;
        }
        return head;
    }
}