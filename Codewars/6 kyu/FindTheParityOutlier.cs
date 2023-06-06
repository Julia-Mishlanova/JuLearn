using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
    public static int FindTheParityOutlier(int[] integers)
    {
        int countOdd = 0;
        int indexOdd = 0;

        int countEven = 0;
        int indexEven = 0;

        for (int i = 0; i < integers.Length; i++)
        {
            if (integers[i] % 2 == 0)
            {
                countEven += 1;
                indexEven = i;
                continue;
            }
            countOdd += 1;
            indexOdd = i;
        }
        return countOdd > countEven ? integers[indexEven] : integers[indexOdd];
    }
}
