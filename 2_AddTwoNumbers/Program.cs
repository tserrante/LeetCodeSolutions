namespace AddTwoNumbers;

public class Program
{
    static void Main()
    {
        LinkedList<int> l1 = new LinkedList<int>(new int[] {9,9,9,9,9,9,9});
        LinkedList<int> l2 = new LinkedList<int>(new int[] {9,9,9,9});

        LinkedList<int> sumOfL1L2 = AddTwoNumbers(l1.First, l2.First);
        
        System.Console.WriteLine(sumOfL1L2);
        //LinkedListNode<int> currentNode = sumOfL1L2.First;

        // while(currentNode != null)
        // {
        //     Console.WriteLine(currentNode.Value);
        //     currentNode = currentNode.Next;
        // }        
    }
    
    /**
        l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
       11111111
        9999999
           9999
       10009998          
    */

    public static LinkedList<int> AddTwoLists(LinkedListNode<int> l1, LinkedListNode<int> l2)
    {
        int l1AsInt = default;
        int l2AsInt = default;

        int count = 1;
        while(l1 != null )
        {
            l1AsInt += l1.Value * count;
            count *= 10; 
            l1 = l1.Next;
        }

        count = 1;
        while(l2 != null )
        {
            l2AsInt += l2.Value * count;
            count *= 10; 
            l2 = l2.Next;
        }
        
        int sumOfLists = l1AsInt + l2AsInt;
        string sumAsString = sumOfLists.ToString();
        
        System.Console.WriteLine("Sum of Lists: {0}", sumAsString);
        System.Console.WriteLine("Length of sum: {0}", sumAsString.Length);
        LinkedList<int> returnedList = new LinkedList<int>();
        
        for(int i = 0; i < sumAsString.Length; i++)
        {
            // int num = Convert.ToInt32(sumOfLists / Math.Pow(10, i));
            // Console.WriteLine("power: {0}\tval: {1}", i, num);
            // returnedList.AddLast(new LinkedListNode<int>(num));
            //(sumOfLists / Math.Pow(10, i));
            returnedList.AddFirst(int.Parse(sumAsString[i].ToString()));
        }
        return returnedList;
    }

    public static LinkedListNode<int> AddTwoNumbers(LinkedListNode<int> l1, LinkedListNode<int> l2)
    {
        
    }
}