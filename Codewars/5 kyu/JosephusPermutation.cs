using System;
using System.Collections.Generic;

public class Josephus
{
    public static List<object> JosephusPermutation(List<object> items, int k)
    {
        List<object> result = new List<object>();
        int i = 0;

        while (items.Count > 0)
        {
            i += (k - 1);
            while (i > items.Count - 1)
            {
                i -= items.Count;
            }
            result.Add(items[i]);
            items.RemoveAt(i);
        }

        return result;
    }
}
