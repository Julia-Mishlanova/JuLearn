using System;
using System.Collections.Generic;

namespace Solution
{
  class Digitizer
  {
    public static long[] Digitize(long n)
    {
            var revers = "";
            string num = n.ToString();
            long[] longs = new long[num.Length];

            for (int i = num.Length - 1; i >= 0; i--)
            {
                revers += num[i];
            }
            string rev = revers;

            for (int i = 0; i < rev.Length; i++)
            {
                longs[i] = long.Parse(rev[i].ToString());
            }
            return longs;
    }
  }
}