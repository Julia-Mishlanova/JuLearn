using System;
using System.Collections.Generic;

public class Printer 
{
    public static string PrinterError(String s) 
    {
            Dictionary<String, int> dic = new Dictionary<String, int>();
            var key = "nopqrstuvwxyz";
            var value = new int[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

            for (int i = 0; i < key.Length; i++)
            {
                dic.Add(key[i].ToString(), value[i]);
            }

            var sumOfErrors = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i].ToString()))
                {
                    sumOfErrors += dic[s[i].ToString()];
                }
            }
            return sumOfErrors + "/" + s.Length.ToString();
    }
}