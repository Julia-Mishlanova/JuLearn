using System;
using System.Collections.Generic;

namespace Main
{
    public class Kata
    {
        public static int[] DataReverse(int[] data)
        {
            int length = data.Length / 8;
            int[][] ints = new int[length][];
            List<int> buff = new List<int>() { data[0] };

            int j = 0;
            for (int i = 1; i < data.Length; i++)
            {
                if (i % 8 == 0)
                {
                    ints[j] = buff.ToArray();
                    buff.Clear();

                    j++;
                }
                buff.Add(data[i]);
            }
            ints[j] = buff.ToArray();

            return Concat(ints);
        }

        public static int[] Concat(int[][] ints)
        {
            List<int> gog = new List<int>();
            for (int i = ints.Length - 1; i >= 0; i--)
            {
                gog.AddRange(ints[i]);
            }
            return gog.ToArray();
        }
    }
}
