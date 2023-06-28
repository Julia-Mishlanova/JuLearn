using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class UnaryMessage
{
    public static string Send(string text)
    {
        int value = 0;
        StringBuilder binary = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            value = (byte)text[i];
            binary.Append(Convert.ToString(value, 2).PadLeft(7, '0'));
        }
        string result = EncodeCharacterIntoUnary(binary.ToString());

        return result;
    }

    public static string EncodeCharacterIntoUnary(string binaryChar)
    {
        StringBuilder unary = new StringBuilder();

        for (int i = 0; i < binaryChar.Length; )
        {
            if (binaryChar[i] == '1')
            {
                unary.Append("0 ");

                while (binaryChar[i] != '0')
                {
                    unary.Append('0');
                    if (i == binaryChar.Length - 1)
                    {
                        i++;
                        break;
                    }
                    i++;
                }
                unary.Append(' ');
                continue;
            }

            if (binaryChar[i] == '0')
            {
                unary.Append("00 ");

                while (binaryChar[i] != '1')
                {
                    unary.Append('0');
                    if (i == binaryChar.Length - 1)
                    {
                        i++;
                        break;
                    }
                    i++;
                }
                unary.Append(' ');
            }
        }
        return unary.ToString().TrimEnd();
    }

    public static string Receive(string unary)
    {
        StringBuilder binary = new StringBuilder();

        for (int i = 1; i < unary.Length; )
        {
            if (unary[i - 1] == '0' && unary[i] != '0')
            {
                i++;
                while (unary[i] != ' ')
                {
                    binary.Append('1');
                    if (i == unary.Length - 1)
                    {
                        i++;
                        break;
                    }
                    i++;
                }
                i++;
                continue;
            }

            if (unary[i - 1] == '0' && unary[i] == '0')
            {
                i += 2;
                while (unary[i] != ' ')
                {
                    binary.Append('0');
                    if (i == unary.Length - 1)
                    {
                        i++;
                        break;
                    }
                    i++;
                }
                i++;
                continue;
            }
            i++;
        }
        string result = ConvertBinaryCodeToString(binary.ToString());
        return result;
    }

    public static string ConvertBinaryCodeToString(string binary)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < binary.Length; i++)
        {
            if (i % 7 == 0 && i != 0) sb.Append(' ');
            sb.Append(binary[i]);
        }
        var split = sb.ToString().Split(' ');

        StringBuilder result = new StringBuilder();
        for (int i = 0; i < split.Length; i++)
        {
            var number = Convert.ToInt32(split[i], 2);
            result.Append((char)number);
        }
        return result.ToString();
    }
}
