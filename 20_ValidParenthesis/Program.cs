
namespace ValidParenthesis;

public class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"{IsValidStackMethod("()")}");
        Console.WriteLine($"{IsValidStackMethod("()[]{}")}");
        Console.WriteLine($"{IsValidStackMethod("(]")}");
        Console.WriteLine($"{IsValidStackMethod("([])")}");
        Console.ReadLine();
    }
    public static bool IsValidStackMethod(string s)
    {
        /**
            Using the fact
            '[' - ']' == -2
            '(' - ')' == -1
            '{' - '}' == -2
        **/

        if(s.Length % 2 != 0) return false;

        char[] leftParens = new[] {'[', '{', '('};
        char[] rightParens = new[] {']', '}', ')'};

        Stack<char> evalStack = new Stack<char>();

        for(int i = 0; i < s.Length; i++)
        {
            if(leftParens.Contains(s[i]))
            {
                evalStack.Push(s[i]);
                continue;
            }
            if(rightParens.Contains(s[i]))
            {
                if(!evalStack.Any()) return false;

                int diff = evalStack.Peek() - s[i];

                if(diff < 0 && diff >= -2)
                {
                    evalStack.Pop();
                    continue;
                }
                return false;
            }
        }
        return !evalStack.Any();
    }
    public static bool IsValid(string s)
    {
        bool retVal = false;

        for(int i = 0; i < s.Length-1; i++)
        {
            if(s[i].Equals('(') || s[i].Equals('[') || s[i].Equals('{'))
            {
                retVal = false;
                for(int j = i + 1; j < s.Length; j++)
                {
                    if(s[i].Equals('(') && s[j].Equals(')'))
                    {
                        retVal = true;
                        break;
                    }
                    else if(s[i].Equals('[') && s[j].Equals(']'))
                    {
                        retVal = true;
                        break;
                    }
                    else if(s[i].Equals('{') && s[j].Equals('}'))
                    {
                        retVal = true;
                        break;
                    }
                }
            }
        }

        return retVal;
    }
}