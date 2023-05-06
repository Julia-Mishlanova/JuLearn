using System.Linq;
using System.Collections.Generic;

namespace Solution
{
  public static class ArraysInversion
  {
    public static int[] InvertValues(int[] input)
    {
            var invert = 0;
            List<int> result = new List<int>(input.Length);

            for (int i = 0; i < input.Length; i++)
            {
                invert = input[i] * (-1);
                result.Add(invert);
            }
            return result.ToArray();
    }
  }
}