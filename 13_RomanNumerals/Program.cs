
namespace RomanNumerals;

/*

*/

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"MCMXCIV: {RomanToIntDictionaryMethod("MCMXCIV")}");
        Console.WriteLine($"III: {RomanToIntDictionaryMethod("III")}");
        Console.WriteLine($"LVIII: {RomanToIntDictionaryMethod("LVIII")}");
    }

    public static int RomanToIntDictionaryMethod(string s)
    {
        Dictionary<string, int> RomanToIntDict = new Dictionary<string, int>{
            {"I", 1}, {"V", 5}, {"X", 10}, {"L", 50},
            {"C", 100}, {"D", 500},{"M", 1000}, {"IV", 4},
            {"IX", 9}, {"XL", 40}, {"XC", 90}, {"CD", 400},
            {"CM", 900}
        };

        if(s.Length < 2) return RomanToIntDict[s];
        
        int i = 0;
        int sum = 0;

        while(i < s.Length)
        {
            if(i + 1 < s.Length && RomanToIntDict.ContainsKey($"{s[i]}{s[i + 1]}"))
            {
                sum += RomanToIntDict[$"{s[i]}{s[i + 1]}"];

                if(i + 2 < s.Length)
                {
                    i += 2;
                }
                else
                {
                    return sum;
                }
            }
            else
            {
                sum += RomanToIntDict[s[i].ToString()];
                i++;
            }
        }
        return sum;
    }
}