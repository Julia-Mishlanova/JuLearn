using System.Collections.Generic;

public class Solution
{
    public static string[] SplitString(string str)
    {
        if (str.Length % 2 != 0) str += '_';

        List<string> split = new List<string>();
        for (int i = 0; i < str.Length - 1; i += 2)
        {
            var letter = str[i].ToString();
            var nextLetter = str[i + 1].ToString();
            
            split.Add(letter + nextLetter);
        }
        return split.ToArray();
    }
}
