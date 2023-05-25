public class Kata
{
    public static double SumArray(double[] array)
    {
        double sum = 0;
        for(int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
}