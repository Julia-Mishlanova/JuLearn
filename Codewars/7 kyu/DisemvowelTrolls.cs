using System;
using System.Collections.Generic;

public static class Kata
{
    public static string Disemvowel(string str)
    {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            string key = "aeiouAEIOU";
            string value = "№№№№№№№№№№";
            for (int i = 0; i < key.Length; i++)
            {
                dictionary.Add(key[i].ToString(), value[i].ToString());
            }

            string disVow = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (dictionary.ContainsKey(str[i].ToString()))
                {
                    disVow += dictionary[str[i].ToString()];
                }
                else disVow += str[i].ToString();
            }

            string result = "";
            for (int i = 0; i < disVow.Length; i++)
            {
                if (disVow[i] != '№') result += disVow[i];
            }
            return result;
    }
}