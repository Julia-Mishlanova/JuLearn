public class Kata
{
  public static int[] Maps(int[] x)
  {
            int[] ints = new int[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                ints[i] = x[i] * 2;
            }
            return ints;
  }
}