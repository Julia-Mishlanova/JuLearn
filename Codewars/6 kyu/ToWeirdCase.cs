using System;

public class Kata
{
    public static string ToWeirdCase(string s)
    {
        var letters = s.ToCharArray();

        for (int i = 0, x = 0; i < letters.Length; i++, x++)
        {
            x = (letters[i] == ' ') ? -1 : x;
            letters[i] = (x % 2 == 0 ? char.ToUpper(letters[i]) : char.ToLower(letters[i]));
        }
        return new string(letters);
    }
}
