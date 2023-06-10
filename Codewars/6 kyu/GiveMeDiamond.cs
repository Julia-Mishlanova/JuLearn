using System;
using System.Collections.Generic;
using System.Text;

public class Diamond
{
    public static string print(int n)
    {
        if (n % 2 == 0 || n <= 0) return null;

        string center = new string('*', n);
        List<string> firstPart = new List<string>();
        List<string> secondPart = new List<string>();
        secondPart.Add(center + '\n');

        for (int i = 0; i < (n - 1) / 2; i++)
        {
            secondPart.Add(Create(secondPart[secondPart.Count - 1]));
        }

        for (int j = secondPart.Count - 1; j > 0; j--)
        {
            firstPart.Add(secondPart[j]);
        }

        var top = String.Join("", firstPart.ToArray());
        var bottom = String.Join("", secondPart.ToArray());

        return top + bottom;
    }

    public static string Create(string prevResult)
    {
        var result = prevResult.ToCharArray();
        bool firstStar = true;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < prevResult.Length; i++)
        {
            if (prevResult[i] == ' ')
            {
                sb.Append(prevResult[i]);
                continue;
            }
            if (firstStar)
            {
                firstStar = false;
                sb.Append(' ');
                i++;
                continue;
            }
            sb.Append(prevResult[i]);
        }
        return sb.ToString();
    }
}
