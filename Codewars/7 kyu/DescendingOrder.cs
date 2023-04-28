using System;
using System.Collections.Generic;
using System.Text;

public static class Kata
{
    public static int DescendingOrder(int num)
        {
            List<int> ints = new List<int>();

            var numStr = num.ToString();
            for (int i = 0; i < numStr.Length; i++)
            {
                ints.Add(int.Parse(numStr[i].ToString()));
            }
            
            ints.Sort();
            StringBuilder sB = new StringBuilder();
            for (int i = ints.Count - 1; i >= 0; i--)
            {
                sB.Append(ints[i]);
            }
            return int.Parse(sB.ToString());
        }
}