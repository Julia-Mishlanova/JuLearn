using System;

public class Kata
{
    public static void WaveSort(int[] arr)
    {
        bool isSorted = false;
        var buff = 0;
        while (!isSorted)
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    buff = arr[i + 1];
                    arr[i + 1] = arr[i];
                    arr[i] = buff;
                    isSorted = false;
                    break;
                }
                isSorted = true;
            }

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] < arr[i + 1])
            {
                buff = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = buff;

                i++;
                continue;
            }

            i++;
        }
    }
}
