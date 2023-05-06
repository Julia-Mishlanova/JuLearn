using System.Text;
using System;

public static class Kata
{
  public static string CountSheep(int n)
  {
            if (n == 0) return "";

            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += i + 1;
            }

            StringBuilder sB = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                sB.Append(arr[i] + " sheep...");
            }
            return sB.ToString();
  }
}