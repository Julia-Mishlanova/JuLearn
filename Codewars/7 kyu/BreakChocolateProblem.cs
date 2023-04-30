public class Kata 
{
  public static int BreakChocolate(int n, int m) 
  {
    return (n == 1 && m == 1 || n * m == 0) ? 0 : (n * m) - 1;
  }
}