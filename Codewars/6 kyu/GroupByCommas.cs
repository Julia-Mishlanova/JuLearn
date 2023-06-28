using System;
using System.Linq;
using System.Text;

public static class Kata
{
    public static string GroupByCommas(int n)
    {
        string number = n.ToString();
        var sb = new StringBuilder();
        int counter = 0;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            if (counter == 3)
            {
                sb.Append(",");
                counter = 0;
            }
            sb.Append(number[i]);
            counter++;
        }

        char[] charArray = sb.ToString().ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
