using System;

public class Kata
{
  public static int DifferenceOfSquares(int n)
  {
            int squareOfSum = 0;
            int sumOfSquares = 0;

            for (int i = 1; i < n + 1; i++)
            {
                squareOfSum += i;
                sumOfSquares += (int)Math.Pow(i, 2);
            }
            return (int)Math.Pow(squareOfSum, 2) - sumOfSquares;
  }
}