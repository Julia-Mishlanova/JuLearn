using System;
using System.Collections.Generic;

public class Kata
{
  public static String IsItANum(string str) 
  {
            List<char> number = new List<char>();
            number.AddRange(str);

            for (int i = 0; i < str.Length; i++)
            {
                if ((byte)str[i] < 48 || (byte)str[i] > 57) number.Remove(str[i]);
            }
            return ( number.Count == 0 || number[0] != '0' || number.Count != 11) ? "Not a phone number" : new string(number.ToArray());
  }
}