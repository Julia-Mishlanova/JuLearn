using System;
using System.Collections.Generic;

public static class Kata
{
  public static int WordsToMarks(string str)
  {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            var key = "abcdefghijklmnopqrstuvwxyz";
            var value = 0;

            for (int i = 0; i < key.Length; i++)
            {
                dic.Add(key[i].ToString(), value += 1);
            }

            int sumLet = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (dic.ContainsKey(str[i].ToString()))
                {
                    sumLet += dic[str[i].ToString()];
                }
            }
            return sumLet;
  }
}