using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int MostFrequentItemCount(int[] collection)
  {
            if(collection.Length == 0) return 0;
    
            List<int> listOfInts = new List<int>();
            for (int i = 0; i < collection.Length; i++)
            {
                if (!listOfInts.Contains(collection[i]))
                {
                    listOfInts.Add(collection[i]);
                }
            }

            List<int> countOfInts = new List<int>();
            for (int i = 0; i < listOfInts.Count; i++)
            {
                countOfInts.Add(0);
            }

            for (int i = 0; i < collection.Length; i++)
                for (int j = 0; j < listOfInts.Count; j++)
                {
                    if (collection[i] == listOfInts[j])
                    {
                        countOfInts[j] += 1;
                    }
                }
            return countOfInts.Max();
  }
}