using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static string TitleCase(string title, string minorWords = "")
    {
        if (title.Length == 0) return "";
        if (minorWords == null) minorWords = " ";

        var minor = minorWords.ToLower().Split(' ');
        var words = title.ToLower().Split(' ');

        List<string> result = new List<string>();
        for (int i = 0; i < words.Length; i++)
        {
            if (minor.Contains(words[i]))
            {
                result.Add(words[i]);
                continue;
            }
            result.Add(char.ToUpper(words[i][0]) + words[i].Substring(1));
        }
        string str = String.Join(" ", result);
        return char.ToUpper(str[0]) + str.Substring(1);
    }
}
