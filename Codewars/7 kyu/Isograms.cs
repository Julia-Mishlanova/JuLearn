using System;
using System.Collections.Generic;


public class Kata
{
  public static bool IsIsogram(string str) 
  {
            string strToLow = str.ToLower();
            List<string> words = new List<string>();

            foreach(var item in strToLow)
            {
                if (!words.Contains(item.ToString())) words.Add(item.ToString());
            }
            return (strToLow.Length == words.Count) ? true : false ;
  }
}