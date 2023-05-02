using System;

public class Kata
{
  public static int ModifiedSum(int[] a, int n)
  {
            int sumPow = 0;
            int sumArrDigits = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sumPow += (int)Math.Pow(a[i], n);
                sumArrDigits += a[i];
            }
            return sumPow - sumArrDigits;
  }
}