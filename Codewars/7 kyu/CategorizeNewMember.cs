using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
            List<string> openOrSenior = new List<string>();
            foreach (var item in data)
            {
                if (item[0] >= 55 && item[1] > 7) openOrSenior.Add("Senior");
                else openOrSenior.Add("Open");
            }
            return openOrSenior;
    }
}