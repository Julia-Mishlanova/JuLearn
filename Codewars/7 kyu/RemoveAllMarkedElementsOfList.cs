using System.Collections.Generic;

public class Kata
{
  public static int[] Remove(int[] integerArr, int[] valuesArr)
  {
            for (int i = 0; i < valuesArr.Length; i++)
                for (int j = 0; j < integerArr.Length; j++)
                {
                    if (integerArr[j] == valuesArr[i]) integerArr[j] = 0;
                }

            List<int> ints = new List<int>();
            foreach (var item in integerArr)
            {
                if (item != 0) ints.Add(item);
            }
            return ints.ToArray();
  }
}