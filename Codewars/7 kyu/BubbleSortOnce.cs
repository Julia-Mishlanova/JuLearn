using System.Collections.Generic;
public class Kata
{
    public static int[] BubbleSortOnce(int[] input)
    {
            int cup = 0;
            var input2 = new List<int>();
            input2.AddRange(input);

            for (int i = 0; i < input2.Count - 1; i++)
            {
                if (input2[i] > input2[i + 1])
                {
                    cup = input2[i];
                    input2[i] = input2[i + 1];
                    input2[i + 1] = cup;
                }
            }
            return input2.ToArray();
    }
}