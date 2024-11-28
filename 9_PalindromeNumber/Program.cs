
namespace PalindromeNumber;


/*
Given an integer x, return true if x is a 
palindrome, and false otherwise.

 

Example 1:

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.
Example 2:

Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
Example 3:

Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
 

Constraints:

-231 <= x <= 231 - 1
 

Follow up: Could you solve it without converting the integer to a string?
 */
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Palindrome Number Checker. Enter 'Q' at anytime to quit");
        Console.Write("Enter a number to see if it is a palindrome: ");
        string input = Console.ReadLine();

        while(!input.ToUpper().Equals("Q") && !string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine($"{input} is palindrome: {IsPalindromeUsingStringMethod(int.Parse(input))}");
            
            Console.Write("Enter a number to see if it is a palindrome: ");
            input = Console.ReadLine();
        }
    }

    // public static bool IsPalidromeArithmeticMethod(int n)
    // {

    // }

    public static bool IsPalindromeUsingStringMethod(int n)
    {
        if (n < 0) return false; 
        
        if(n < 10) return true;

        //char[] num = n.ToString().ToCharArray();
        string num = n.ToString();
        for(int i = 0; i < num.Length; i++)
        {
            char leftNum = num[i];
            char rightNum = num[num.Length - 1 - i];
            if(!leftNum.Equals(rightNum))
            {
                return false;
            }
            if(i+1 == num.Length - 1 - i)
            {
                break;
            }
        }
        return true;
    }
}