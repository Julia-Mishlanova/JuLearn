using System.Collections.Generic;

public class Kata
{
  public static int DontGiveMeFive(int start, int end)
  {
            List<int> ints = new List<int>();
            int i = start;
            while (i <= end)
            {
                if (i.ToString().Contains('5'))
                {
                  i++;
                 continue;
                } 
                i += 1;
                ints.Add(i);
            }
            return ints.Count;
  }
}