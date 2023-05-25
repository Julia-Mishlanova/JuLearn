using System;

public static class Kata
{
  public static int[] ReverseSeq(int n)
  {
            int[] ints = new int[n];
            for (int i = n; i > 0; i--)
            {
                ints[n - i] = i;
            }
            return ints;
  }
}