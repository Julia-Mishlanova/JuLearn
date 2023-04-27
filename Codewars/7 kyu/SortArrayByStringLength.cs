public class Kata
{
  public static string[] SortByLength (string[] array)
  {
            var buffStr = "";
            bool isSorted = false;
            while (!isSorted)
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i].Length > array[i + 1].Length)
                    {
                        buffStr = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = buffStr;
                        isSorted = false;
                            break;
                    }
                    isSorted = true;
                }
            
            return array;
  }
}