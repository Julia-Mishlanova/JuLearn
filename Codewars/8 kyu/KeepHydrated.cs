using System;

public class Kata
{
  public static int Litres(double time)
  {
            double water = 0.5;
            double litres = time * water;
            int result = (int)Math.Floor(litres);
            return result;
  }
}