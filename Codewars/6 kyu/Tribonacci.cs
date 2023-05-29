using System.Collections.Generic;

public class Xbonacci
{
  public double[] Tribonacci(double[] signature, int n)
  {
            List<double> tribonacci = new List<double>(signature);

            for (int i = 1; i < n; i++)
            {
                tribonacci.Add(tribonacci[i - 1] + tribonacci[i] + tribonacci[i + 1]);
            }

            List<double> result = new List<double>();
            for (int i = 0; i < n; i++)
            {
                result.Add(tribonacci[i]);
            }
            return result.ToArray();
  }
}