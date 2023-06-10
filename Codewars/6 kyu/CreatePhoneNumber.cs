public class Kata
{
    public static string CreatePhoneNumber(int[] numbers)
    {
        var a = string.Empty;
        for (int i = 0; i < 3; i++)
        {
            a += numbers[i].ToString();
        }

        var b = string.Empty;
        for (int i = 3; i < 6; i++)
        {
            b += numbers[i].ToString();
        }

        var c = string.Empty;
        for (int i = 6; i < numbers.Length; i++)
        {
            c += numbers[i].ToString();
        }
        return string.Format("({0}) {1}-{2}", a, b, c);
    }
}
