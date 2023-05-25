public static class Kata
{
 public static int Pillars(int numPill, int dist, int width)
  {
            if (numPill <= 1) return 0;
            if (numPill == 2)
            {
                int distInCen = dist * 100;
                int a = distInCen * (numPill - 1);
                return a;
            }
            else
            {
                int distInCen = dist * 100;
                int a = distInCen * (numPill - 1);
                int b = width * (numPill - 2);
                int all = a + b;
                return all;

            }
  }
}