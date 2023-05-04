using System.Linq;
using System.Collections.Generic;
using System;

public class Kata
{
  public static int GetAverage(int[] marks)
  {
            int sum = 0;
            foreach (var item in marks) sum += item;
            
            double result = sum / marks.Length;
            return (int)Math.Round(result);
  }
}