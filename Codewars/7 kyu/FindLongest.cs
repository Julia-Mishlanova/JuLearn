public class Kata
{
  public static int FindLongest(int[] number)
  {
            int max = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (max.ToString().Length < number[i].ToString().Length)
                {
                    max = number[i];
                }
            }
            return max;
  }
}