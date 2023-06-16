using System.Linq;
using System.Text;

public static class Kata
{
    public static string StringTops(string msg)
    {
        StringBuilder rawResult = new StringBuilder();
        int n = 0;
        for (int i = 0; i < msg.Length; i += n)
        {
            rawResult.Append(msg[i]);
            n += 1;
        }

        string top = string.Empty;
        for (int i = 1; i < rawResult.Length; i += 2)
        {
            top += rawResult[i];
        }
        var result = top.Reverse();
        return new string(result.ToArray());
    }
}
