using System;

public static class Kata
{
  public static string GenerateShape(int n)
  {
            if (n == 1) return "+";
            if (n == 0) return "";

            string shape = "";
            for (int i = 0; i < n; i++)
            {
                if (i == n - 1) shape += new string('+', n);
                else shape += new string('+', n) + '\n';
            }
            return shape;
  }
}