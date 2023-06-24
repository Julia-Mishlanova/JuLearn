public class TwistedSum
{
    public static long Solution(long n)
    {
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += Sum(i + 1);
        }
        return sum;
    }

    public static int Sum(int n)
    {
        int sum = 0;
        string numb = n.ToString();

        for (int i = 0; i < numb.Length; i++)
        {
            sum += int.Parse(numb[i].ToString());
        }
        return sum;
    }
}
