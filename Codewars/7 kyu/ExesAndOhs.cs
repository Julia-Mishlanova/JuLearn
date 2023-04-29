using System.Linq;
using System;
public static class Kata 
{
  public static bool XO (string input)
  {
            char[] chars = input.ToCharArray();
            var xCount = 0;
            var oCount = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                if (char.ToLower(chars[i]) == 'x') xCount = xCount + 1;               
                if (char.ToLower(chars[i]) == 'o') oCount = oCount + 1;
            }

            if (xCount == oCount) return true;
            else return false;
  }
}