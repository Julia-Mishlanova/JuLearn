using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public static int [] SimpleRemoveDuplicates(int [] arr)
    {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!map.ContainsKey(arr[i]))
                {
                    map.Add(arr[i], i);
                }
                else map[arr[i]] = i;
            }

            List<int> listOfNums = new List<int>();
            var sort = map.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (var v in sort)
            {
                listOfNums.Add(v.Key);
            }
            return listOfNums.ToArray();
    }
}