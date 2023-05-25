public static class Kata
{
    public static int ArrayPlusArray(int[] arr1, int[] arr2)
    {
        int sum = 0;
  
        foreach (var item in arr1)
        {
            sum += item;
        }
        
        foreach (var item in arr2)
        {
            sum += item;
        }
        return sum;
    }
}