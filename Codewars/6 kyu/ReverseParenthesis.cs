using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public static int ReverseParenthesis(string s)
    {
        if (s.Length % 2 != 0)
            return -1;
        string parentheses = RemovePairs(s);
        return Reverse(parentheses);
    }

    public static string RemovePairs(string s)
    {
        string splitPair = s;
        string joinResult = string.Empty;
        string[] macaroni = new string[s.Length];
        bool pairsOver = false;

        while (!pairsOver)
        {
            macaroni = splitPair.Split(new string[] { "()" }, StringSplitOptions.None);
            joinResult = string.Join("", macaroni);
            if (splitPair == joinResult)
            {
                pairsOver = true;
                continue;
            }
            splitPair = joinResult;
        }
        return splitPair;
    }

    public static int Reverse(string parentheses)
    {
        var chars = parentheses.ToCharArray();
        int halfLength = parentheses.Length / 2;
        int countChanges = 0;

        for (int i = 0; i < chars.Length - 1; i++)
        {
            if (chars[i] == '(' && chars[i] == chars[i + 1])
            {
                countChanges++;
                i++;
                continue;
            }
            if (chars[i] != chars[i + 1])
            {
                countChanges += 2;
                continue;
            }
            if (chars[i] == ')' && chars[i] == chars[i + 1])
            {
                countChanges++;
                i++;
            }
        }
        return countChanges;
    }
}
