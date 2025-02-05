
namespace LongestCommonPrefix;

public class Program
{
    public static void Main()
    {
        string[] strs1 = ["flower","flow","flight"];
        string[] strs2 = ["dog","racecar","car"];
        string[] strs3 = ["race", "racecar", "raccoon"];

        // Console.WriteLine(LongestCommonPrefix_HorizontalScanning(strs1));
        // Console.WriteLine(LongestCommonPrefix_HorizontalScanning(strs2));
        // Console.WriteLine(LongestCommonPrefix_HorizontalScanning(strs3));

        // Console.WriteLine(LongestCommonPrefix_VerticalScanning(strs1));
        // Console.WriteLine(LongestCommonPrefix_VerticalScanning(strs2));
        // Console.WriteLine(LongestCommonPrefix_VerticalScanning(strs3));

        Console.WriteLine(LongestCommonPrefix_StartsWith(strs1));
        Console.WriteLine(LongestCommonPrefix_StartsWith(strs2));
        Console.WriteLine(LongestCommonPrefix_StartsWith(strs3));

        Console.ReadLine();
    }

    public static string LongestCommonPrefix_StartsWith(string[] strs)
    {
        if(strs.Length == 0)
            return string.Empty;

        string prefix = strs[0];
        for(int i = 1; i < strs.Length; i++)
        {
            while(!strs[i].StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if(string.IsNullOrEmpty(prefix))
                {
                    return string.Empty;
                }
            }   
        }

        return prefix;
    }

    // 1ms run time, beats 90.15%, 43.0 MB
    public static string LongestCommonPrefix_VerticalScanning(string[] strs)
    {
        if(strs.Length == 0)
            return string.Empty;

        for(int i = 0; i < strs[0].Length; i++)
        {
            char c = strs[0][i];

            for(int j = 1; j < strs.Length; j++)
            {
                if(strs[j].Length == i || strs[j][i] != c)
                {
                    return strs[0].Substring(0, i);
                }
            }
        }

        return strs[0];
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