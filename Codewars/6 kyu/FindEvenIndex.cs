public class Kata
{
    public static int FindEvenIndex(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (EqualSides(i, arr)) return i;
        }
        return -1;
    }
    public static bool EqualSides(int currentInd, int[] array)
    {
        int countFirstSide = 0;
        int countSecondSide = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i < currentInd) countFirstSide += array[i];
            if (i > currentInd) countSecondSide += array[i];
        }
        return countFirstSide == countSecondSide ? true : false;
    }
}
