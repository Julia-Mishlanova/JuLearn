using System.Collections.Generic;

namespace Solution
{
  class Kata
  {
      public static int FindOddInt(int[] seq) 
      {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < seq.Length; i++)
            {
                if (!map.ContainsKey(seq[i]))
                {
                    map.Add(seq[i], 1);
                    continue;
                }
                map[seq[i]] += 1;
            }

            foreach (var item in map)
            {
                if (item.Value % 2 != 0) return item.Key;
            }
            return 0;
      }
       
  }
}