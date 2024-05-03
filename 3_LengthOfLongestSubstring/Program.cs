using System.Collections.Generic;
// Console.WriteLine("testing: " + "abcabcbb: --> " + Set_LengthOfLongestSubstring("abcabcbb"));
// Console.WriteLine("testing: " + "bbbbbb: --> " + Set_LengthOfLongestSubstring("bbbbbb"));
Console.WriteLine("testing: " + "pwwkew: --> " + Set_LengthOfLongestSubstring("pwwkew"));
// Console.WriteLine("testing: " + "au: --> " + Set_LengthOfLongestSubstring("au"));
// Console.WriteLine("testing: " + "' ': --> " + Set_LengthOfLongestSubstring(" "));

int FirstSubmission_LengthOfLongestSubstring(string s) 
{

    if(s.Length <= 1)
    {
        return s.Length;
    }

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

int Set_LengthOfLongestSubstring(string s)
{
    HashSet<char> substring = new HashSet<char>();

    bool isAdded = false;
    int leftIndex = 0; 
    int rightIndex = 0;
    int maxLength = 0;

    while(rightIndex < s.Length && leftIndex < s.Length)
    {
        isAdded = substring.Add(s[rightIndex]);

        if(isAdded)
        {
            rightIndex++;
            if(substring.Count > maxLength)
                maxLength = substring.Count;
        }
        else
        {
            substring.Remove(s[leftIndex]);
            leftIndex++;
        }

    }
    return maxLength;
}