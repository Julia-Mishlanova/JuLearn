using System.Collections.Generic;
public class Kata
{
  public static int[] FindAll(int[] array, int n)
  {
            List<int> index = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i]==n)
                {
                    index.Add(i);
                }
            }
            return index.ToArray();
  }
}