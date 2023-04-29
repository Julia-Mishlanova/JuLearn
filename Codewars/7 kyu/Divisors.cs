using System.Collections.Generic;

public class Kata
{
  public static int Divisors(int n)
  {
            int num = n;
            List<int> ints = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (num == 0) return ints.Count;
                if (n % num == 0)
                {
                    ints.Add(num);
                    num -= 1;
                }
                else num -= 1;
            }
            return ints.Count;
  }
}