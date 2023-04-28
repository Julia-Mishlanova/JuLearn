using System;
  public class Sum
  {
     public int GetSum(int a, int b)
     {
            if (a <= b)
            {
                int g = a;
                int sum = a;
                while (g < b)
                {
                    g += 1;
                    sum += g;
                }
                return sum;
            }

            if (a >= b)
            {
                int k = a;
                int sum = a;
                while (k > b)
                {
                    k -= 1;
                    sum += k;
                }
                return sum;
            }
            return 0;
     }
  }