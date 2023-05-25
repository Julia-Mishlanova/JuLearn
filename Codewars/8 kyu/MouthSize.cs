public class Kata
{
    public static string MouthSize(string animal)
    {
        string low = animal.ToLower();
        if (low == "alligator") return "small";
        else return "wide";
    }
}