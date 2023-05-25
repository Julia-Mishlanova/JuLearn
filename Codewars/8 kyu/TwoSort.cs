using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

public class Kata
{
  public static string TwoSort(string[] s)
  {
            Array.Sort(s, StringComparer.Ordinal);
            string word = s[0];
            StringBuilder sB = new StringBuilder();
            for (int i = 0; i < word.Length; i++)
            {
                if (i == word.Length) sB.Append(word[i]);
                sB.Append(word[i] + "***");
            }
            string result = sB.ToString();
            return result.Remove(result.Length - 3, 3);
  }  
}