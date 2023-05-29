using System;
using System.Collections.Generic;

public class Kata
{
    public static Dictionary<char, int> CountCharacters(string str)
    {
        var count = new Dictionary<char, int>();

        for (int i = 0; i < str.Length; i++)
        {
            if (!count.ContainsKey(str[i]))
            {
                count.Add(str[i], 1);
                continue;
            }
            count[str[i]] += 1;
        }
        return count;
    }
}
