using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Dinglemouse
{
    public static Dictionary<char, int> dic = new Dictionary<char, int>()
    {
        {'b', 1},{'f', 1},{'p', 1},{'v', 1},
        {'c', 2},{'g', 2},{'j', 2},{'k', 2},{'q', 2},{'s', 2},{'x', 2},{'z', 2},
        {'d', 3},{'t', 3 },
        {'l', 4},
        {'m', 5}, {'n', 5},
        {'r', 6}
    };

    public static string Soundex(string names)
    {
        var words = names.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            var code = Encode(words[i]);
            words[i] = RemoveAllAdjacent(code + "0");
            words[i] = RemoveVowels(words[i]);
            words[i] = CheckFirstLetter(words[i]);
        }

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i].PadRight(4, '0');
            words[i] = words[i].Substring(0, 4);
        }
        return string.Join(" ", words);
    }

    public static string Encode(string name)
    {
        string result = name[0].ToString();
        for (int i = 1; i < name.Length; i++)
        {
            char letter = name[i];

            if (letter == 'h' || letter == 'w')continue;

            if (dic.ContainsKey(letter))
            {
                result += dic[letter];
                continue;
            }
            result += letter;
        }
        return result;
    }

    public static string RemoveAllAdjacent(string code)
    {
        if (code.Length <= 2) return code;

        string result = string.Empty;
        for (int i = 0; i < code.Length - 1; i++)
        {
            while (code[i] == code[i + 1])
            {
                i++;
                if (i + 1 >= code.Length) break;
            }
            result += code[i];
        }
        return result;
    }

    public static string RemoveVowels(string code)
    {
        if (code.Length <= 2) return code;

        char[] vowels = new char[] { 'a', 'o', 'e', 'i', 'u', 'y' };
        string result = code[0].ToString();

        for (int i = 1; i < code.Length; i++)
        {
            if (vowels.Contains(code[i])) continue;
            result += code[i];
        }
        return result;
    }

    public static string CheckFirstLetter(string code)
    {
        code = code[0].ToString().ToUpper() + code.Substring(1);
        if (code.Length <= 3) return code;

        var firstLetter = char.ToLower(code[0]);
        var secondLetter = code[1];

        int firstLettVal = 0;
        int secondLettVal = int.Parse(secondLetter.ToString());
        if (dic.ContainsKey(firstLetter)) firstLettVal = dic[firstLetter];

        if (firstLettVal == secondLettVal)
        {
            code = code.Remove(1, 1);
        }
        return code;
    }
}
