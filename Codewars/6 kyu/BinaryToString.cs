using System;
using System.Text;

public static class Kata
{
    public static string BinaryToString(string binary)
    {
        if (binary == string.Empty) return string.Empty;
        var binaryIsolate = new StringBuilder();

        for (int i = 0; i < binary.Length; i++)
        {
            if (i % 8 == 0 && i != 0)
                binaryIsolate.Append(' ');

            binaryIsolate.Append(binary[i]);
        }
        var split = binaryIsolate.ToString().Split(' ');

        var result = new StringBuilder();
        for (int i = 0; i < split.Length; i++)
        {
            int number = Convert.ToInt32(split[i], 2);
            result.Append((char)number);
        }

        return result.ToString();
    }
}
