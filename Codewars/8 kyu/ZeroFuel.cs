using System;

public static class Kata
{
  public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
  {
      uint check = fuelLeft * mpg;
      if (check < distanceToPump) return false;
      else return true;
  }
}