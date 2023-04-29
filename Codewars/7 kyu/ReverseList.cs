using System.Collections.Generic;

namespace Solution
{
  public static class Program
  {
    public static int[] reverseList(int[] list)
    {
            List<int> result = new List<int>();
            for (int i = list.Length - 1; i >= 0; i--)
            {
                result.Add(list[i]);
            }
            return result.ToArray();
    }
  }
}