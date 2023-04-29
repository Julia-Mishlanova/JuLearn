using System;

public class Kata
{
        public static bool IsAscOrder(int[] arr)
        {
            int[] sortArr = new int[arr.Length];
            for (int i = 0; i < sortArr.Length; i++)
            {
                sortArr[i] += arr[i];
            }

            int buff = 0;
            bool isSorted = false;
            while (!isSorted)
            {
                for (int i = 0; i < sortArr.Length - 1; i++)
                {
                    if (sortArr[i] > sortArr[i+1])
                    {
                        buff = sortArr[i + 1];
                        sortArr[i + 1] = sortArr[i];
                        sortArr[i] = buff;
                        isSorted = false;
                            break;
                    }
                    isSorted = true;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != sortArr[i]) return false;
            }
            return true;

        }
}