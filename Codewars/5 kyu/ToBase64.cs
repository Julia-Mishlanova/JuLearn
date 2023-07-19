using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Base64Utils
{
    public static string ToBase64(string s)
    {
        if (s == string.Empty) return string.Empty;

        List<int> ASCIIValue = new List<int>();
        for (int i = 0; i < s.Length; i++)
        {
          ASCIIValue.Add(s[i]);
        }

        StringBuilder bits8 = new StringBuilder();
        for (int i = 0; i < ASCIIValue.Count; i++)
        {
          bits8.Append(GetBits(ASCIIValue[i], 8));
        }

        string base64Table = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
        List<char> chars = new List<char>();
        string buff = string.Empty;

        for (int i = 0; i < bits8.Length; i++)
        {
            if (i % 6 == 0 && i != 0)
            {
              var sextetValue = Convert.ToInt32(buff.PadRight(6, '0'), 2);
              chars.Add(base64Table[sextetValue]);
              buff = string.Empty;
            }
            buff += bits8[i];
        }
        var value = Convert.ToInt32(buff.PadRight(6, '0'), 2);
        chars.Add(base64Table[value]);

        string result = new string(chars.ToArray());

        while (result.Length % 4 != 0)
        {
          result += "=";
        }

        return result;
    }

    private static string GetBits(int ASCIIValue, int bit)
    {
      return new string(Convert.ToString(ASCIIValue, 2).PadLeft(bit, '0').ToArray());
    }

    public static string FromBase64(string s)
    {
        if (s == string.Empty) return string.Empty;

        string base64Table = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
        List<int> sextetValues = new List<int>();
        for (int i = 0; i < s.Length; i++)
        {
          if (s[i] != '=')
          {
            sextetValues.Add(base64Table.IndexOf(s[i]));
          }
        }

        StringBuilder bits6 = new StringBuilder();
        for (int i = 0; i < sextetValues.Count; i++)
        {
          bits6.Append(GetBits(sextetValues[i], 6));
        }

        List<char> chars = new List<char>();
        string buff = string.Empty;
        var octetValue = 0;
        var ch = '\0';

        for (int i = 0; i < bits6.Length; i++)
        {
            if (i % 8 == 0 && i != 0)
            {
                octetValue = Convert.ToInt32(buff, 2);
                ch = (char)octetValue;

                if (ch != '\0')
                {
                    chars.Add(ch);
                }
                buff = string.Empty;
            }
            buff += bits6[i];
        }
        octetValue = Convert.ToInt32(buff, 2);
        ch = (char)octetValue;
        if (ch != '\0') chars.Add(ch);

        return new string(chars.ToArray());
    }
}
