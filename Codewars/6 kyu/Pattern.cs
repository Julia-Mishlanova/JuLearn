using System.Collections.Generic;
using System.Text;

public class Pattern14
{
    public static string end = string.Empty;

    public static string Pattern(int n, int y = 0)
    {
        if (n < 1) return "";

        List<string> pattern = GetFirstHalf(n);

        for (int i = pattern.Count - 2; i >= 1; i--)
        {
            pattern.Add(pattern[i]);
        }
        string rhomb = string.Join("\n", pattern);
        if (y <= 1) return rhomb + '\n' + end;

        StringBuilder result = new StringBuilder();
        for (int i = 0; i < y; i++)
        {
            result.Append(rhomb + '\n');
        }

        return result.Append(end).ToString();
    }

    public static List<string> GetFirstHalf(int n)
    {
        int length = (n * 2) - 1;

        char point = '\0';
        int numForPoint = 0;

        var arr = new string(' ', length).ToCharArray();

        List<string> result = new List<string>();

        int j = arr.Length - 1;
        for (int i = 0; i < n; i++)
        {
            if (i < n)
            {
                if (numForPoint == 9)
                {
                    numForPoint = -1;
                }
                point = char.Parse((numForPoint += 1).ToString());
            }

            arr[i] = point;
            arr[j] = point;

            result.Add(new string(arr));
            if (i == 0) end = new string(arr);

            arr[i] = ' ';
            arr[j] = ' ';
            j--;
        }
        return result;
    }
}
