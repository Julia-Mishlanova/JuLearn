using System.Text;
using System.Collections.Generic;

public class Abbreviator
{
    public static string Abbreviate(string input)
    {
        HashSet<char> chars = new HashSet<char>();
        foreach (var item in input)
        {
            if (!char.IsLetter(item)) chars.Add(item);
        }

        if (chars.Count == 0)
        {
            if (input.Length <= 3) return input;
            return Abbreviation(input);
        }

        string sentence = input + '@';
        StringBuilder sB = new StringBuilder();
        string buff = string.Empty;

        for (int i = 0; i < sentence.Length; i++)
        {
            buff = string.Empty;
            while (char.IsLetter(sentence[i]))
            {
                buff += sentence[i];
                i++;
            }
            if (buff.Length > 3)
            {
                sB.Append(Abbreviation(buff) + sentence[i]);
                continue;
            }
            sB.Append(buff + sentence[i]);
        }
        return sB.ToString().Trim('@');
    }

    public static string Abbreviation(string word)
    {
        int numberRemovedCh = word.Length - 2;
        return word[0] + numberRemovedCh.ToString() + word[word.Length - 1];
    }
}
