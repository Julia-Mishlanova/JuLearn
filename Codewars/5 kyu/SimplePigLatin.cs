using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Kata
{
    public static string PigIt(string str)
    {
        var split = str.Split(' ');
        var letters = new char[split.Length][];
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < split.Length; i++)
        {
            letters[i] = split[i].ToCharArray();
        }

        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i].Length == 1)
            {
                char letter = char.Parse(new string(letters[i]));
                if (IsPunctuation(letter))
                {
                    sb.Append(letter + " ");
                    continue;
                }
            }
            sb.Append(Encode(letters[i]) + ' ');
        }

        return sb.ToString().TrimEnd();
    }

    public static bool IsPunctuation(char s)
    {
        if (s == '.'
            || s == ','
            || s == ';'
            || s == ':'
            || s == '!'
            || s == '?') return true;

        return false;
    }

    public static string Encode(char[] letters)
    {
        string punctuation = string.Empty;
        string word = string.Empty;
        char firstLetter = letters[0];

        for (int i = 1; i < letters.Length; i++)
        {
            if (IsPunctuation(letters[i]))
            {
                punctuation += letters[i];
                continue;
            }
            word += letters[i];
        }
        return word + firstLetter + "ay" + punctuation;
    }
}
