using System.Text;
using System.Collections.Generic;

public static class Kata
{
    public static string FormatWords(string[] words)
    {
        if (words == null) return "";

        List<string> withoutEmptyStr = new List<string>();
        foreach (var word in words)
        {
            if (word != "") withoutEmptyStr.Add(word);
        }

        int wordsCount = withoutEmptyStr.Count;

        StringBuilder sentence = new StringBuilder();
        for (int i = 0; i < wordsCount; i++)
        {
            if (wordsCount == 1) return withoutEmptyStr[i];

            if (i == wordsCount - 1)
            {
                sentence.Append(" and " + withoutEmptyStr[i]);
                continue;
            }
            sentence.Append(", " + withoutEmptyStr[i]);
        }
        return sentence.ToString().TrimStart(' ', ',');
    }
}
