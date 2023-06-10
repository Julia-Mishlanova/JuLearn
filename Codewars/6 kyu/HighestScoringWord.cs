using System.Collections.Generic;

public class Kata
{
    public static string HighestScoringWord(string s)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();
        var key = "abcdefghijklmnopqrstuvwxyz";

        for (int i = 0; i < key.Length; i++)
        {
            dic.Add(key[i], i + 1);
        }

        var words = s.Split(' ');
        int[] score = new int[words.Length];

        for (int i = 0; i < words.Length; i++)
            for (int j = 0; j < words[i].Length; j++)
            {
                if (dic.ContainsKey(words[i][j]))
                {
                    score[i] += dic[words[i][j]];
                }
            }
        return GetResult(score, words);
    }

    public static string GetResult(int[] score, string[] words)
    {
        int high = 0;
        int index = 0;
        for (int i = 0; i < score.Length; i++)
        {
            if (high < score[i])
            {
                high = score[i];
                index = i;
            }
        }
        return words[index];
    }
}
