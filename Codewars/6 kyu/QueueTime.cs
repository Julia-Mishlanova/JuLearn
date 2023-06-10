using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static long QueueTime(int[] customers, int n)
    {
        if (n == 1) return customers.Sum();
        if (n > customers.Length) return customers.Max();

        List<int> queue = new List<int>();
        queue.AddRange(customers);

        List<int> checkOut = new List<int>();

        for (int j = 0; j < n; j++)
        {
            checkOut.Add(customers[j]);
            queue.RemoveAt(0);
        }

        bool AllGone = false;
        int time = 0;

        while (checkOut.Count != 0)
        {
            for (int i = 0; i < checkOut.Count; i++)
            {
                checkOut[i] -= 1;

                if (checkOut[i] == 0 && queue.Count > 0)
                {
                    checkOut[i] = queue[0];
                    queue.RemoveAt(0);
                }

                if (queue.Count == 0)
                {
                    for (int j = 0; j < checkOut.Count; j++)
                    {
                        if (checkOut[j] == 0)
                        {
                            checkOut.RemoveAt(j);
                            j--;
                            i--;
                        }
                    }
                }
            }
            time++;
        }
        return time;
    }
}
