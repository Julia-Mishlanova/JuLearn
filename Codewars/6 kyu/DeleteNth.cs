using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] DeleteNth(int[] arr, int x)
    {
        HashSet<int> uniq = new HashSet<int>();
        foreach (var item in arr)
        {
            uniq.Add(item);
        }

        List<int> motif = new List<int>(arr);
        foreach (var item in uniq)
        {
            motif = MotifCounter(item, motif, x);
        }
        return motif.ToArray();
    }

    public static List<int> MotifCounter(int num, List<int> motif, int acceptQuantity)
    {
        int count = 0;
        List<int> curResult = new List<int>();

        for (int i = 0; i < motif.Count; i++)
        {
            if (motif[i] == num && count >= acceptQuantity) continue;

            if (motif[i] == num)
            {
                curResult.Add(motif[i]);
                count += 1;
                continue;
            }
            curResult.Add(motif[i]);
        }
        return curResult;
    }
}
