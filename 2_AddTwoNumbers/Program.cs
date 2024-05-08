using System;

namespace AddTwoNumbers;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Program
{
    static void Main()
    {
        


    }
    
    /**
        l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
       11111111
        9999999
           9999
       10009998          
    */

    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        // we create a blank ListNode with 0 value
        ListNode result = new ListNode(0);

        // take a blank listnode in head for our operation
        ListNode head = result;

        // take two variable sum for sum two value and carry for carried out sum carry
        int sum = 0;
        int carry = 0;

        // while loop until both list node is not null
        while (l1 != null || l2 != null)
        {
            // if l1 null than replace with blank node
            if (l1 == null)
                l1 = new ListNode(0);

            // if l2 is null than replace with blannode
            if (l2 == null)
                l2 = new ListNode(0);

            // now we sum the value of listnode and previous carry and remove carry and add in listnode
            sum = (l1.val + l2.val + carry) % 10;
            result.next = new ListNode(sum);

            // now we carry a carried in carry variable from sum of both listnode value and previous  carry 
            carry = (l1.val + l2.val + carry) / 10;
            l1 = l1.next;
            l2 = l2.next;
            result = result.next;
        }

        // if we carry is greater than 0 than add at last
        if (carry > 0)
            result.next = new ListNode(carry);

        // than we return listnode with remove first blank listnode
        return head.next;
    }

    public static void PrintList(ListNode node)
    {
        string sum = string.Empty;
        while(node != null) 
        {
            sum += node.val.ToString();
            node = node.next;
        }
        Console.WriteLine("printing in order... : " + sum);
    }
}
