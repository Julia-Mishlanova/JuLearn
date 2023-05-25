using System;
using System.Collections.Generic;

public static class Kata
{
  public static string Replace(string s)
  {
            Dictionary <string, string> dic = new Dictionary<string, string>();
            var key = "aeiouAEIOU";
            var value = "!!!!!!!!!!";

            for (int i = 0; i < key.Length; i++)
            {
                dic.Add(key[i].ToString(), value[i].ToString());
            }

            string replace = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i].ToString()))
                {
                    replace += dic[s[i].ToString()];
                }
                else replace += s[i].ToString();
            }
            return replace;
  }
}