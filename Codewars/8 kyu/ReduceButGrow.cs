public class Kata
{
  public static int Grow(int[] x)
  {
            int grow = 1;
            foreach (var num in x)
            {
                grow *= num;
            }
            return grow;
  }
}