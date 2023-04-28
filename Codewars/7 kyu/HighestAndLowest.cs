using System;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
            String[] num = numbers.Split(' ');
            int[] numToInt = Array.ConvertAll(num, int.Parse);

            int max = numToInt[0];
            for (int i = 0; i < numToInt.Length; i++) if (numToInt[i] > max) max = numToInt[i];

            int min = numToInt[0];
            for (int i = 0; i < numToInt.Length; i++) if (numToInt[i] < min) min = numToInt[i];
            
            return max.ToString() + " " + min.ToString();
  }
}