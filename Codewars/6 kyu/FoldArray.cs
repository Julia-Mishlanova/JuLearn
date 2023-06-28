using System.Collections.Generic;

public class Kata
{
    public static int[] FoldArray(int[] array, int runs)
    {
        for (int i = 0; i < runs; i++)
        {
            array = Flip(array);
        }
        return array;
    }
    public static int[] Flip(int[] array)
    {
        List<int> ints = new List<int>();
        int lengthArr = array.Length;

        int middle = (lengthArr + 1) / 2;
        int j = lengthArr - 1;

        for (int i = 0; i < middle; i++, j--)
        {
            ints.Add(array[i]);
            if (i == middle - 1 && lengthArr % 2 != 0) break;
            ints[i] += array[j];
        }

        return ints.ToArray();
    }
}
