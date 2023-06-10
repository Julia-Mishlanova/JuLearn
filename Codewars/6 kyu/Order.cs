using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static string Order(string str)
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        var words = str.Split(' ');

        for (int i = 0; i < words.Length; i++)
            for (int j = 0; j < words[i].Length; j++)
            {
                if (char.IsDigit(words[i][j]))
                {
                    int num = int.Parse(words[i][j].ToString());
                    dic.Add(words[i], num);
                    break;
                }
            }

        var output = dic.OrderBy(e => e.Value).Select(e => e.Key).ToList();
        return string.Join(" ", output);
    }
}
