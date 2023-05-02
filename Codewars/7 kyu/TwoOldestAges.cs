using System.Collections.Generic;

public class LargestTwo
{
  public static int[] TwoOldestAges(int[] ages)
  {
            int firstOldestAge = 0;
            for (int i = 0; i < ages.Length; i++)
            {
                if (firstOldestAge < ages[i]) firstOldestAge = ages[i];
            }

            List<int> listOfNewAges = new List<int>();
            bool hasDouble = false;
            foreach (var item in ages)
            {
                if (item == firstOldestAge && hasDouble) return new int[] { firstOldestAge, firstOldestAge };
                if (firstOldestAge == item && !hasDouble) hasDouble = true;
                if (item != firstOldestAge) listOfNewAges.Add(item);
            }

            int secondOldestAge = 0;
            for (int i = 0; i < listOfNewAges.Count; i++)
            {
                if (secondOldestAge < listOfNewAges[i]) secondOldestAge = listOfNewAges[i];
            }
            int[] twoOldest = { secondOldestAge, firstOldestAge };
            return twoOldest;
  }
}