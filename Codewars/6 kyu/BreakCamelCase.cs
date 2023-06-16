using System.Text;

public class Kata
{
    public static string BreakCamelCase(string word)
    {
        var result = new StringBuilder();

        foreach (char letter in word)
        {
            if ('A' <= letter && 'Z' >= letter)
            {
                result.Append(" ");
            }
            result.Append(letter);
        }
        return result.ToString();
    }
}
