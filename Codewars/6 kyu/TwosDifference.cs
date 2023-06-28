using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static (int, int)[] TwosDifference(int[] array)
    {
        Array.Sort(array);
        var differences = new List<(int num1, int num2)>();
        int secondDifference = 0;
        var tuple = (0, 0);

        for (int i = 0; i < array.Length; i++)
        {
            secondDifference = GetSecondDifference(array, array[i]);
            if (secondDifference == 0) continue;

            tuple = (array[i], secondDifference);
            differences.Add(tuple);
        }
        return differences.ToArray();
    }

    public static int GetSecondDifference(int[] array, int item)
    {
        int difference = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (item + 2 == array[i])
            {
                difference = array[i];
                continue;
            }
        }
        return difference;
    }
}
