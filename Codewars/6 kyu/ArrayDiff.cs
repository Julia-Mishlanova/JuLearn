using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] ArrayDiff(int[] a, int[] b)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < a.Length; i++)
        {
            if (!b.Contains(a[i])) result.Add(a[i]);
        }

        return result.ToArray();
    }
}
