
namespace RomanNumerals;

/*

*/

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"MCMXCIV: {RomanToIntMethod3("MCMXCIV")}");
        Console.WriteLine($"III: {RomanToIntMethod3("III")}");
        Console.WriteLine($"LVIII: {RomanToIntMethod3("LVIII")}");
    }
    private static int CalcScale(char c, char a1, char a2)
    {
        return (c == a1 || c == a2) ? -1 : 1;
    }
    public static int RomanToIntMethod3(string s)
    {
        int result = 0;

        for(int i = 0; i < s.Length; i ++)
        {
            char nextChar = (i + 1 < s.Length) ? s[i + 1] : '\0';

            switch (s[i])
            {
                case 'M': result += 1000; break;
                case 'D': result += 500; break;
                case 'C': result += 100 * CalcScale(nextChar, 'M', 'D'); break;
                case 'L': result += 50; break;
                case 'X': result += 10 * CalcScale(nextChar, 'C', 'L'); break;
                case 'V': result += 5; break;
                case 'I': result += 1 * CalcScale(nextChar, 'X', 'V'); break;
            }
        }
        return result;
    }

    public static int RomanToIntDictionaryMethod2(string s)
    {
        Dictionary<char, int> RomanToIntDict = new Dictionary<char, int>{
            {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50},
            {'C', 100}, {'D', 500},{'M', 1000}
        };

        if(s.Length < 2) return RomanToIntDict[s[0]];

        int sum = 0;

        for(int i = 0; i < s.Length - 1; i++)
        {
            if(RomanToIntDict[s[i]] < RomanToIntDict[s[i + 1]])
            {
                sum -= RomanToIntDict[s[i]];
            }
            else
            {
                sum += RomanToIntDict[s[i]];
            }
        }
        return sum + RomanToIntDict[s[s.Length - 1]];
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