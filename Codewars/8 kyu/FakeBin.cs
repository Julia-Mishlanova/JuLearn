public class Kata
{
    public static string FakeBin(string x)
    {
        string bin = "";
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] >= '5') bin += '1';
            if (x[i] < '5') bin += '0';
        }
        return bin;
    }
}