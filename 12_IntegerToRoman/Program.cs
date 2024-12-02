using System.Text;

namespace IntegerToRoman;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("1990 - {0}", IntToRomanDict(1990));
        Console.WriteLine("3994 - {0}", IntToRoman(3994));
        Console.WriteLine("50 - {0}", IntToRoman(50));
    }
    public static string IntToRomanDict(int num)
    {
        var romanNumberBuilder = new StringBuilder();
        var romansMap = new Dictionary<int, string> 
        {
            { 1000, "M" }, { 900, "CM" }, { 500, "D" },
            { 400, "CD" }, { 100, "C" }, { 90, "XC" },
            { 50, "L" }, { 40, "XL" },{ 10, "X" },
            { 9, "IX" }, { 5, "V" }, { 4, "IV" },
            { 1, "I" }
        };

        foreach(var romanInt in romansMap.Keys)
        {
            while(romanInt <= num)
            {
                romanNumberBuilder.Append(romansMap[romanInt]);
                num -= romanInt;
            }
        }

        var romanNumber = romanNumberBuilder.ToString();
        return romanNumber;
    }

    public static string IntToRoman(int num)
    {
        if (num >= 1000) return "M" + IntToRoman(num - 1000);

        if (num >= 900) return "CM" + IntToRoman(num - 900);

        if (num >= 500) return "D" + IntToRoman(num - 500);

        if (num >= 400) return "CD" + IntToRoman(num - 400);

        if (num >= 100) return "C" + IntToRoman(num - 100);

        if (num >= 90) return "XC" + IntToRoman(num - 90);

        if (num >= 50) return "L" + IntToRoman(num - 50);

        if (num >= 40) return "XL" + IntToRoman(num - 40);

        if (num >= 10) return "X" + IntToRoman(num - 10);

        if (num >= 9) return "IX" + IntToRoman(num - 9);

        if (num >= 5) return "V" + IntToRoman(num - 5);

        if (num >= 4) return "IV" + IntToRoman(num - 4);

        if (num >= 1) return "I" + IntToRoman(num - 1);

        return "";
    }
}