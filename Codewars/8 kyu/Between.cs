using System.Collections.Generic;
public class Kata 
{
  public static int[] Between(int a, int b)
  {
            List<int> list = new List<int>();
            for (int i = 0; a < b + 1; i++) // not i < b+1 !!!
            {
                list.Add(a++);
            }
            return list.ToArray();
  }
}