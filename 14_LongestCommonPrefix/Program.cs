
namespace LongestCommonPrefix;

public class Program
{
    public static void Main()
    {
        string[] strs1 = ["flower","flow","flight"];
        string[] strs2 = ["dog","racecar","car"];
        string[] strs3 = ["race", "racecar", "raccoon"];

        Console.WriteLine(LongestCommonPrefix_HorizontalScanning(strs1));
        Console.WriteLine(LongestCommonPrefix_HorizontalScanning(strs2));
        Console.WriteLine(LongestCommonPrefix_HorizontalScanning(strs3));

        Console.ReadLine();
    }

    

    // 8ms run time, beats 19.49%, 44.13 MB
    public static string LongestCommonPrefix_HorizontalScanning(string[] strs)
    {
        if(strs.Length == 0)
            return string.Empty;
        
        string prefix = strs[0];

        for(int i = 1; i < strs.Length; i++)
        {
            while(strs[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length-1);
                if(prefix.Equals(string.Empty))
                {
                    return string.Empty;
                }
            }
        }
        return prefix;
    }
}