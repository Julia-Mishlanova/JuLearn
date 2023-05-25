using System.Text;
using System;

public class Kata
{
  public static string DrawStairs(int n)
  {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i < n; i++)
            {
                result.Append("I" + "\n" + new string(' ', i));
            }
            return result + "I";
  }
}