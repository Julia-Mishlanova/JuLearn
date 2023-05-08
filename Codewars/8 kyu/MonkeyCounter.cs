public static class MonkeyCounter
{
  public static int[] MonkeyCount(int n)
  {
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += i+1;
            }
            return arr;
  }
}