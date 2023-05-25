public class Kata
{
  public static string WhatDay(int n)
  {
            if (n < 1 || n > 7) return "Wrong, please enter a number between 1 and 7";
    
            string[] dayOfWeek = 
            { 
                "Sunday", 
                "Monday", 
                "Tuesday", 
                "Wednesday", 
                "Thursday", 
                "Friday", 
                "Saturday" 
            };

            for (int i = 0; i < dayOfWeek.Length; i++)
            {
                if (i == n - 1) return dayOfWeek[i];
            }
            return string.Empty;
  }
}