public class Kata
{
  public static bool SmallEnough(int[] a, int limit)
  {
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] <= limit)
         continue;
         else return false;
    }
      return true;
  }
}