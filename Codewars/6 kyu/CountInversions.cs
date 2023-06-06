public class Kata
{
    public static int CountInversions(int[] array)
    {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            result += Counter(i, array[i], array);
        }
        return result;
    }

    public static int Counter(int currentInd, int num, int[] array)
    {
        int count = 0;
        for (int i = currentInd; i < array.Length; i++)
        {
            if (num > array[i]) count++;
        }
        return count;
    }
}
