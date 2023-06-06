using System.Collections.Generic;
using System.Text;

public class Kata
{
    public static string DecipherThis(string s)
    {
        if (s == "") return "";

        var words = s.Split(' ');

        if (!s.Contains(' ') && char.IsLetter(s[s.Length - 1]))
        {
            return SwapPlaces(s);
        }
        if (words.Length == 1)
        {
            return OneLetter(s).ToString();
        }

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < words.Length; i++)
        {
            sb.Append(SwapPlaces(words[i]) + " ");
        }
        return sb.ToString().Trim();
    }

    public static string SwapPlaces(string word)
    {
        List<char> letters = new List<char>();
        char buff = ' ';
        string digit = "";

        for (int i = 0; i < word.Length; i++)
        {
            if (char.IsDigit(word[i]))
            {
                digit += word[i];
                continue;
            }
            letters.Add(word[i]);
        }

        if (letters.Count == 0)
        {
            return OneLetter(word).ToString();
        }

        buff = letters[letters.Count - 1];
        letters[letters.Count - 1] = letters[0];
        letters[0] = buff;

        int value = int.Parse(digit);

        return (char)value + new string(letters.ToArray());
    }

    public static char OneLetter(string s)
    {
        string digit = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsDigit(s[i]))
            {
                digit += s[i];
                continue;
            }
        }
        int value = int.Parse(digit);
        return (char)value;
    }
}
