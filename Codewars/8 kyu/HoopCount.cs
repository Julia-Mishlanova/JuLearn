public class Kata
{
    public static string HoopCount(int n)
    {
        if (n < 10) return "Keep at it until you get it";
        if (n >= 10) return "Great, now move on to tricks";
        return string.Empty;
    }
}