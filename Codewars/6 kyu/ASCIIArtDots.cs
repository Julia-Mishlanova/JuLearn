using System.Text;

public class Kata
{
    public static string Dot(int n, int m)
    {
        var border = new StringBuilder();
        var middle = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            if (n == 1)
            {
                border.Append("+---+\n");
                middle.Append("| o |\n");
                continue;
            }
            if (i == 0)
            {
                border.Append("+---+");
                middle.Append("| o |");
                continue;
            }
            if (i == n - 1)
            {
                border.Append("---+\n");
                middle.Append(" o |\n");
                continue;
            }

            border.Append("---+");
            middle.Append(" o |");
        }

        string bord = border.ToString();
        string midd = middle.ToString();

        var result = new StringBuilder();
        for (int i = 0; i < m; i++)
        {
            if (i == 0)
            {
                result.Append(bord + midd + bord);
                continue;
            }
            result.Append(midd + bord);
        }
        return result.ToString().TrimEnd('\n');
    }
}
