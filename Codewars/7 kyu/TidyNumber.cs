using System;
using System.Collections.Generic;

class Kata
{
    public static bool TidyNumber(int n)
    {
            string num = Convert.ToString(n);
            List<int> ints = new List<int>();

            for (int i = 0; i < num.Length; i++)
            {
                ints.Add(int.Parse(num[i].ToString()));
            }

            for (int i = 0; i < ints.Count - 1; i++)
            {
                if (ints[i] > ints[i + 1]) return false;
            }
            return true;
    }
}