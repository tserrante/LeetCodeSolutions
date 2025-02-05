
namespace LongestCommonPrefix;

public class Program
{
    public static void Main()
    {
        
    }

    public static string LongestCommonPrefix(string[] strs) 
    {
        if(strs.Length == 0)
            return string.Empty;

        string prefix = string.Empty;
        /*
            read first character of current string and add to prefix
                look for another string starting with that character
                    if a match is found
                        append char to prefix string
                        check if other characters in that string match
                        append if other characters found
                    if a match is not found
                        clear prefix string
                    
        */
        for(int i = 0; i < strs.Length - 1; i++)
        {
            //string currentString = strs[i];
            //char currentChar = strs[i][0];
            for(int j = i + 1; j < strs.Length; j++)
            {
                if(strs[j][0] == strs[i][0])
                {
                    
                }
            }
        }
    }
}