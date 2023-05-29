using System.Text;

public class Kata
{
    public static string ToCamelCase(string str)
    {
        var split = str.Split('-', '_');
        StringBuilder camelCase = new StringBuilder();
        for (int i = 0; i < split.Length; i++)
        {
            if (i == 0)
            {
                camelCase.Append(split[i]);
                continue;
            }
            camelCase.Append(char.ToUpper(split[i][0]) + split[i].Substring(1));
        }
        return camelCase.ToString();
    }
}
