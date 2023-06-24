using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int lengthForSubstr = 0;
    public static int[][] GroupIn10s(int[] array)
    {
        if (array.Length == 0) return new int[][] { };

        int length = GetLength(array) + 1;

        int[][] result = new int[length][];

        for (int i = 0; i < length; i++)
        {
            int[] ints = Search10s(i, array);
            if (ints.Length == 0)
            {
                result[i] = null;
                continue;
            }
            result[i] = ints;
        }

        return result;
    }

    public static int[] Search10s(int ten, int[] array)
    {
        string tenth = ten.ToString();
        string firstNum = string.Empty;

        List<int> ints = new List<int>();

        for (int i = 0; i < array.Length; i++)
        {
            if (ten == 0)
            {
                if (array[i] < 10) ints.Add(array[i]);
                continue;
            }

            string num = array[i].ToString();

            if (num.Length == 1 && ten > 0) continue;

            firstNum = num.Substring(0, lengthForSubstr);
            if (firstNum == tenth)
            {
                ints.Add(array[i]);
            }
        }

        ints.Sort();
        return ints.ToArray();
    }

    public static int GetLength(int[] array)
    {
        int max = array.Max();
        if (max < 10) return 0;

        string maxStr = max.ToString();
        lengthForSubstr = maxStr.Length - 1;

        string firstNum = maxStr.Substring(0, lengthForSubstr);
        return int.Parse(firstNum);
    }
}
