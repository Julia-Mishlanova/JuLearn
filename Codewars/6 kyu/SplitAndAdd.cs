using System.Collections.Generic;

namespace Solution
{
    public class Kata
    {
        public static int[] SplitAndAdd(int[] numbers, int n)
        {
            int[] result = numbers;
            int i = 0;
            while (i != n)
            {
                result = Split(result);
                i++;
            }
            return result;
        }

        public static int[] Split(int[] numbers)
        {
            List<int> partOne = new List<int>();
            List<int> partTwo = new List<int>();
            int splitInd = 0;

            if (numbers.Length % 2 != 0)
            {
                splitInd = (numbers.Length - 1) / 2;
                partOne.Add(0);
            }
            else
                splitInd = numbers.Length / 2;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i <= splitInd - 1)
                {
                    partOne.Add(numbers[i]);
                    continue;
                }
                partTwo.Add(numbers[i]);
            }

            for (int i = partTwo.Count - 1; i >= 0; i--)
            {
                partTwo[i] += partOne[i];
            }
            return partTwo.ToArray();
        }
    }
}
