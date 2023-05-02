using System;

public class Kata
{
  public static string CatMouse(string x)
  {
            int countDot = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == '.') countDot += 1;
            }
            return countDot > 3 ? "Escaped!" : "Caught!";
  }
}