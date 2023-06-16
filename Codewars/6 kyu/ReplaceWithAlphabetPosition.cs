using System.Collections.Generic;
using System.Text;

public static class Kata
{
    public static string ReplaceWithAlphabetPosition(string t)
    {
        string text = t.ToLower();
        Dictionary<char, int> dic = new Dictionary<char, int>();
        var key = "abcdefghijklmnopqrstuvwxyz";

        for (int i = 0; i < key.Length; i++)
        {
            dic.Add(key[i], i + 1);
        }

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            if (dic.ContainsKey(text[i]))
                sb.Append(dic[text[i]] + " ");
        }
        return sb.ToString().TrimEnd(' ');
    }
}
