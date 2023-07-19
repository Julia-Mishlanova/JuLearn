using System.Collections.Generic;

public class Kata
{
    public static int[] MoveZeroes(int[] arr)
    {
        int zeroesCount = 0;
        List<int> otherNums = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                zeroesCount++;
                continue;
            }
            otherNums.Add(arr[i]);
        }
        int[] zeroes = new int[zeroesCount];
        otherNums.AddRange(zeroes);

        return otherNums.ToArray();
    }
}
