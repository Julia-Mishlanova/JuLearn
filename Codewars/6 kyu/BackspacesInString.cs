using System.Text;

public class Kata
{
    public static string CleanString(string s)
    {
        int buff = 0;
        var letters = s.ToCharArray();
        for (int i = letters.Length - 1; i >= 0; i--)
        {
            if (letters[i] == '#')
            {
                letters[i] = '\0';
                buff += 1;
                continue;
            }
            if (letters[i] != '#' && buff >= 1)
            {
                letters[i] = '\0';
                buff -= 1;
                continue;
            }
        }

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i] == '\0') continue;

            sb.Append(letters[i]);
        }
        return sb.ToString();
    }
}
