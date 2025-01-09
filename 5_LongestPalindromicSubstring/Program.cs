
using System.Text;

namespace LongestPalindromicSubstring;

public class Program
{
    public static void Main()
    {
        string test1 = "babad";
        string test2 = "cbbd";
        string testWtf = "wsgdzojcrxtfqcfkhhcuxxnbwtxzkkeunmpdsqfvgfjhusholnwrhmzexhfqppatkexuzdllrbaxygmovqwfvmmbvuuctcwxhrmepxmnxlxdkyzfsqypuroxdczuilbjypnirljxfgpuhhgusflhalorkcvqfknnkqyprxlwmakqszsdqnfovptsgbppvejvukbxaybccxzeqcjhmnexlaafmycwopxntuisxcitxdbarsicvwrvjmxsapmhbbnuivzhkgcrshokkioagwidhmfzjwwywastecjsolxmhfnmgommkoimiwlgwxxdsxhuwwjhpxxgmeuzhdzmuqhmhnfwwokgvwsznfcoxbferdonrexzanpymxtfojodcfydedlxmxeffhwjeegqnagoqlwwdctbqnuxngrgovrjesrkjrfjawknbrsfywljscfvnjhczhyeoyzrtbkvvfvofykkwoiclgxyaddhpdoztdhcbauaagjmfzkkdqexkczfsztckdlujgqzjyuittnudpldjvsbwbzcsazjpxrwfafievenvuetzcxynnmskoytgznvqdlkhaowjtetveahpjguiowkiuvikwewmgxhgfjuzkgrkqhmxxavbriftadtogmhlatczusxkktcsyrnwjbeshifzbykqibghmmvecwwtwdcscikyzyiqlgwzycptlxiwfaigyhrlgtjocvajcnqyenxrnjgogeqtvkxllxpuoxargzgcsfwavwbnktchwjebvwwhfghqkcjhuhuqwcdsixrkfjxuzvhjxlyoxswdlwfytgbtqbeimzzogzrlovcdpseoafuxfmrhdswwictsctawjanvoafvzqanvhaohgndbsxlzuymvfflyswnkvpsvqezekeidadatsymbvgwobdrixisknqpehddjrsntkqpsfxictqbnedjmsveurvrtvpvzbengdijkfcogpcrvwyf";
        Console.WriteLine($"{test1} -> {LongestPalindrome(test1)}");
        Console.WriteLine($"{test2} -> {LongestPalindrome(test2)}");
        Console.WriteLine($"testWtf -> {LongestPalindrome(testWtf)}");
    }
        // brute force, too slow!  Fails on long input like testWtf
        public static string LongestPalindrome(string s) 
        {
            HashSet<string> palindromes = new HashSet<string>();
            
            for(int i = 0; i < s.Length; i++)
            {
                for(int j = i + 1; j <= s.Length; j++)
                {
                    string str = s.Substring(i, j - i);
                    char[] revChars = str.ToCharArray();
                    Array.Reverse(revChars);
                    string revStr = new string(revChars);
                    if(str.Equals(revStr))
                    {
                        palindromes.Add(str);
                    }
                }
            }
            return palindromes.Aggregate("", (max, curr) => max.Length > curr.Length ? max : curr);
        }
}