using System.Collections.Generic;

public static class Kata
{
	public static int SumTwoSmallestNumbers(int[] numbers)
	{
		        int firstMin = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (firstMin > numbers[i]) firstMin = numbers[i];
            }

            List<int> newFirst = new List<int>();
            bool hasDouble = false;
            foreach (var item in numbers)
            {
                if (item == firstMin && hasDouble) return firstMin + firstMin;
                if (item == firstMin && !hasDouble) hasDouble = true;
                if (item != firstMin) newFirst.Add(item);
            }

            int secondMin = newFirst[0];
            for (int i = 0; i < newFirst.Count; i++)
            {
                if (secondMin > newFirst[i]) secondMin = newFirst[i];
            }
            return firstMin + secondMin;
	}
}