using System;

public static class Kata
{
  public static string Solution(string str) 
  {
            char[] chars = str.ToCharArray();
            string reverse = "";

            for (int i = chars.Length - 1; i >= 0; i--)
            {
                reverse = reverse + chars[i];
            }
            return reverse;
  }
}