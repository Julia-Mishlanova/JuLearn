using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

public class SolutionMaxDepth
{
    public static List<string> StringsInMaxDepth(string s)
    {
        if (!s.Contains('(')) return new List<string>(new string[] { s });
        int currentDepth = 0;
        int max = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                currentDepth += 1;
                if (currentDepth > max) max = currentDepth;
            }
            if (s[i] == ')')
            {
                currentDepth = currentDepth == 0 ? 0 : currentDepth - 1;
            }
        }

        currentDepth = 0;
        List<string> result = new List<string>();
        string buff = string.Empty;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                currentDepth += 1;
            }

            if (currentDepth == max && s[i] == '(')
            {
                i++;
                while (s[i] != ')')
                {
                    buff += s[i];
                    i++;
                }

                result.Add(buff);
                buff = string.Empty;
            }

            if (s[i] == ')')
            {
                currentDepth = currentDepth == 0 ? 0 : currentDepth - 1;
            }
        }
        return result;
    }
}
