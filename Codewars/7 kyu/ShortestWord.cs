using System;
using System.Collections.Generic;

public class Kata
{
  public static int FindShort(string s)
  {
            String[] words = s.Split(' ');
            List<int> len = new List<int>();
            
            for (int i = 0; i < words.Length; i++) len.Add(words[i].Length);

            int min = len[0];
            int minInd = 0;
            for (int i = 0; i < len.Count; i++)
            {
                if (len[i] < min)
                {
                    minInd = i;
                    min = len[i];
                }
            }
            return min;
  }
}