using System;

public class Kata
{
  public static bool IsSquare(int n)
  {
            
            if (n < 0) return false;
            int d = (int)Math.Sqrt(n);
            int h = d * d;
            if (h == n) return true;
            else return false;
  }
  
}