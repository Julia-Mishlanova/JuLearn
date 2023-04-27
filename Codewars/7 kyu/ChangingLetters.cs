using System;
using System.Collections.Generic;

public static class Kata
{
  public static string Swap(string s)
  {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            var key = "aeiouAEIOU";
            var value = "AEIOUAEIOU";

            for (int i = 0; i < key.Length; i++)
            {
                dic.Add(key[i].ToString(), value[i].ToString()); 
            }

            string swap = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i].ToString()))
                {
                    swap += dic[s[i].ToString()]; 
                }
                else swap += s[i].ToString();
            }
            return swap;
  }
}