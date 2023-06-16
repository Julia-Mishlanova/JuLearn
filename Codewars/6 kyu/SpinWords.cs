using System.Text;

public class Kata
{
    public static string SpinWords(string sentence)
    {
        var split = sentence.Split(' ');
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < split.Length; i++)
        {
            if (split[i].Length < 5)
            {
                sb.Append(split[i] + " ");
                continue;
            }
            sb.Append(Reverse(split[i]) + " ");
        }
        return sb.ToString().TrimEnd();
    }

    public static string Reverse(string word)
    {
        string result = "";
        for (int i = word.Length - 1; i >= 0; i--)
        {
            result += word[i];
        }
        return result;
    }
}
