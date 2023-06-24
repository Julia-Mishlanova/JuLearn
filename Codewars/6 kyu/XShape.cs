using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

public static class Kata
{
    public static string X(int n)
    {
        string middle = new String('□', n);
        var point = middle.ToCharArray();

        List<string> firstLine = new List<string>();

        for (int i = 0; i < point.Length; i++)
        {
            point[i] = '■';
            firstLine.Add(new string(point));
            point[i] = '□';
        }

        int j = firstLine.Count - 1;
        for (int i = 0; i < firstLine.Count; i++)
        {
            firstLine[i] = GetSecondLine(firstLine[i], j);
            j--;
        }
        return string.Join("\n", firstLine);
    }

    public static string GetSecondLine(string point, int i)
    {
        var arr = point.ToCharArray();
        arr[i] = '■';
        return new string(arr);
    }
}
