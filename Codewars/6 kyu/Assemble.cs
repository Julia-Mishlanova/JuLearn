public class Kata
{
    public static string Assemble(string[] copies)
    {
        if (copies.Length == 0 || copies[0] == "") return "";

        char[] result = new char[copies[0].Length];
        for (int j = 0; j < copies[0].Length; j++)
        {
            if (copies[0][j] == '*')
            {
                result[j] += Search(j, copies);
                continue;
            }
            result[j] += copies[0][j];
        }
        return new string(result);
    }

    public static char Search(int ind, string[] copies)
    {
        for (int i = 1; i < copies.Length; i++)
            for (int j = ind; j < copies[i].Length; j++)
            {
                if (j == ind && copies[i][j] != '*')
                {
                    return copies[i][j];
                }
            }
        return '#';
    }
}
