using System.Collections.Generic;
using System;

public class Kata
{
  public static string[] AddLength(string str)
  {
            String[] words = str.Split(' ');
            List<string> strInt = new List<string>();   
            int len = 0;

            for (int i = 0; i < words.Length; i++)
            {
                len = words[i].Length;
                strInt.Add(words[i] + " " + len.ToString());
            }
            return strInt.ToArray();
  }
}