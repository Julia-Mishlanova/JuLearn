using System.Collections.Generic;

class Solution 
{
        public static int Stray(int[] numbers)
        {
            var uniq = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!uniq.Contains(numbers[i])) uniq.Add(numbers[i]);
            }

            int FirstType = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == uniq[0]) FirstType += 1;
            }
          
            if (FirstType == 1) return uniq[0];
            else return uniq[1];
        }
}