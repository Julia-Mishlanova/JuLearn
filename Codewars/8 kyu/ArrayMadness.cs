public class Kata
{
    public static bool ArrayMadness(int[] a, int[] b)
    {
        int sumSqrA = 0;
        for (int i = 0; i < a.Length; i++) sumSqrA += a[i] * a[i];

        int sumCubB = 0;
        for (int i = 0; i < b.Length; i++) sumCubB += b[i] * b[i] * b[i];

        if (sumSqrA > sumCubB) return true;
        else return false;
    }
}