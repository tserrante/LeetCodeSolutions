using System.Collections.Generic;

namespace AddTwoNumbers;

public class Program
{
    static void Main()
    {

    }
    
    /**
        l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
             
        9999999
           9999
              8          
    */

    public LinkedListNode<int> AddTwoNumbers(LinkedListNode<int> l1, LinkedListNode<int> l2)
    {
        int l1AsInt = default;
        int l2AsInt = default;
        int count = 1;
        while(l1.Next != null )
        {
            l1AsInt += l1.Value * count;
            count *= 10; 
            l1 = l1.Next;
        }

        count = 1;
        while(l2.Next != null )
        {
            l2AsInt += l2.Value * count;
            count *= 10; 
            l2 = l2.Next;
        }
        
        int sumOfLists = l1AsInt + l2AsInt;

        LinkedList<int> returnedList = new LinkedList<int>();
        

    }
}