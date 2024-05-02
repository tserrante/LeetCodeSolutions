// Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
// Console.WriteLine(LengthOfLongestSubstring("bbbbbb"));
// Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
Console.WriteLine(LengthOfLongestSubstring("au"));

int LengthOfLongestSubstring(string s) 
{
    int returnLength = 0;
    for(int i = 0; i < s.Length - 1; i++)
    {
        string substring = s[i].ToString();
        
        for(int j = i + 1; j < s.Length; j++)
        {
            if(!substring.Contains(s[j]))
            {
                substring += s[j];
            }
            else
            {
                break;
            }
        }
        if(substring.Length > returnLength)
        {
            returnLength = substring.Length;
        }
    }
    return returnLength;
}