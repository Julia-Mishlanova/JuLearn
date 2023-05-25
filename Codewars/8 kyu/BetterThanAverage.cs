using System;

public class Kata
{
  public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
  {
            int sumOfClassP = 0;
            foreach (var point in ClassPoints)
            {
                sumOfClassP += point;
            }
            
            double averageOfClassP = sumOfClassP / ClassPoints.Length;
            return (YourPoints > Math.Ceiling(averageOfClassP)) ? true : false;
  }
}