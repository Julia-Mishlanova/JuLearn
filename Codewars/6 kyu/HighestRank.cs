using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int HighestRank(int[] arr)
    {
        Dictionary<int, int> result = new Dictionary<int, int>();
        foreach (var item in arr)
        {
            if (!result.ContainsKey(item))
            {
                result.Add(item, 1);
                continue;
            }
            result[item] += 1;
        }

        int maxCount = 0;
        foreach (var item in result)
        {
            if (maxCount <= item.Value)
            {
                maxCount = item.Value;
            }
        }
        return CheckSameRank(maxCount, result);
    }

    public static int CheckSameRank(int max, Dictionary<int, int> result)
    {
        List<int> same = new List<int>();
        foreach (var item in result)
        {
            if (item.Value == max)
            {
                same.Add(item.Key);
            }
        }
        return same.Max();
    }
}
