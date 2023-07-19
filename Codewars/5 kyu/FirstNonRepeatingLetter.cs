using System;

public class Kata
{
    public static string FirstNonRepeatingLetter(string s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (LetterRepeat(s, s[i], i) == false) return s[i].ToString();
        }
        return string.Empty;
    }

    public static bool LetterRepeat(string str, char letter, int indexIgnore)
    {
        str = str.ToLower();
        letter = Char.ToLower(letter);

        for (int i = 0; i < indexIgnore; i++)
        {
            if (str[i] == letter) return true;
        }

        for (int i = indexIgnore + 1; i < str.Length; i++)
        {
            if (str[i] == letter) return true;
        }
        return false;
    }
}
