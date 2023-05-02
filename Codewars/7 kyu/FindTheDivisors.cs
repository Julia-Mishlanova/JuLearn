using System.Collections.Generic;

public class Kata
{
  public static int[] Divisors(int n)
  {
            int buff = 2;
    
            List<int> listOfDivisors = new List<int>();
            while(buff != n)
            {
                if (n % buff == 0) listOfDivisors.Add(buff);
                buff++;
            }

            if (listOfDivisors.Count == 0) return null;
            return listOfDivisors.ToArray();
  }
}