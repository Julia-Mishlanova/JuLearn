using System;
using System.Collections.Generic;
using System.Linq;

public class Remover
{
  public static List<int> RemoveSmallest(List<int> numbers)
  {
            if (numbers.Count == 0) return new List<int>();
    
            int small = numbers[0];
            for (int i = 0; i < numbers.Count(); i++)
            {
                if (small > numbers[i]) small = numbers[i];
            }

            List<int> removeSmall = new List<int>();
            bool hasDouble = false;
            for (int i = 0; i < numbers.Count(); i++)
            {
                if (numbers[i] == small && hasDouble) removeSmall.Add(numbers[i]);
                if (numbers[i] == small && !hasDouble) hasDouble = true;
                if (numbers[i] != small) removeSmall.Add(numbers[i]);
            }
            return removeSmall;
  }
}