using System;
using System.Collections.Generic;

public static class Kata
{
  public static string RemoveDuplicateWords(string s)
  {
            var strings = s.Split(' ');
            List<string> unique = new List<string>();
            foreach (var i in strings) 
            {
                if (!unique.Contains(i)) unique.Add(i);
            }

            string result = "";
            foreach (var item in unique)
            {
                result += item + " ";
            }
            return result.TrimEnd(' ');
  }
}