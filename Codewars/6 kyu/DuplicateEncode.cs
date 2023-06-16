using System.Collections.Generic;

public class Kata
{
    public static string DuplicateEncode(string w)
    {
        string word = w.ToLower();

        string gog = "";
        for (int j = 0; j < word.Length; j++)
        {
            if (CheckDublicate(word[j], word) == true)
            {
                gog += ')';
                continue;
            }
            gog += '(';
        }
        return gog;
    }

    public static bool CheckDublicate(char uniq, string word)
    {
        bool hasDublicate = false;
        for (int i = 0; i < word.Length; i++)
        {
            if (hasDublicate == true && uniq == word[i]) return true;
            if (uniq == word[i] && hasDublicate == false) hasDublicate = true;
        }
        return false;
    }
}
