using System.Collections.Generic;

public static class Kata
{
    public static int[] Incrementer(int[] numbers)
    {
            int[] pow = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                pow[i] = i + 1;
            }

            int sum = 0;
            List<int> inc = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = numbers[i] + pow[i];
                if (sum >= 10) inc.Add(sum % 10);
                else inc.Add(sum);
            }
            return inc.ToArray();
    }
}