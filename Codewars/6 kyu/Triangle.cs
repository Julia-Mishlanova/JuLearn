using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Kata
{
    public static string Triangle(string row)
    {
        string result = row;
        while (result.Length != 0)
        {
            if (result.Length == 1) break;
            result = GetRow(result);
        }
        return result;
    }

    public static string GetRow(string row)
    {
        var dic = new Dictionary<char, int>();
        string alphabet = "abcdefghijklmnopqrstuvwxyz";

        for (int i = 0; i < alphabet.Length; i++)
        {
            dic.Add(alphabet[i], i + 1);
        }

        int value = 0;
        var result = new StringBuilder();

        for (int i = 0; i < row.Length - 1; i++)
        {
            value = dic[row[i]] + dic[row[i + 1]];
            if (value > 26) value -= 26;

            var letter = dic.FirstOrDefault(x => x.Value == value).Key;
            result.Append(letter);
        }
        return result.ToString();
    }
}
