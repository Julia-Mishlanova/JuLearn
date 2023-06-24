using System.Linq;

public class Kata
{
    public static int CountBits(int n)
    {
        string bits = "";
        double division = (double)n;
        var remains = new string[2];

        while (division != 0)
        {
            division /= 2;
            remains = division.ToString().Split('.');

            if (remains.Length == 2)
            {
                bits += '1';
                division = int.Parse(remains[0]);
                continue;
            }
            bits += '0';
        }
        return bits.Count(x => x == '1');
    }
}
