
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
        // negative numbers always return false
        // single digit numbers either always true or false

        // double digit
        // divide by 
        // 10 - false
        // 11 - true
        // ... false
        // 20 - false
        // 21 - false
        // 22 - true

        // triple digits
        // 100 - false
        // 101 - true
        // ... false
        // 111 - true

    }

    public bool IsPalindrome(int n)
    {
        if (n < 0) return false; 

        if(n <= 9) return true;

        if(n <= 99)
        {
            int r = n / 10;

           // if(r == n % 10)
        }

        if(n <= 230)
        {

        }
    }
}