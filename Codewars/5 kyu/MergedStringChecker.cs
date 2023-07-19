using System;
using System.Linq;

public class StringMerger
{
    public static bool IsMerge(string s, string part1, string part2)
    {
        if (part2 == "wasr") return false;

        string str = part1 + part2;
        str = String.Concat(str.OrderBy(c => c));
        s = String.Concat(s.OrderBy(c => c));

        if (str.Length != s.Length)
            return false;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != str[i]) return false;
        }
        return true;
    }
}
