using System.Collections.Generic;
using System;
using System.Linq;

public class CaesarCipher
{
    const int PIECE_FOR_EACH_RUNNER = 5;

    public static List<string> movingShift(string s, int shift)
    {
        int primaryShift = shift;
        var symbols = s.ToCharArray();

        for (int i = 0; i < symbols.Length; i++)
        {
            if (char.IsLetter(symbols[i]) && char.IsLower(symbols[i]))
            {
                int newLetter = symbols[i] + shift;

                symbols[i] =
                    newLetter > 122
                        ? BeyondTheBoundOfAlphabetMov(newLetter, 122, 96)
                        : (char)newLetter;

                shift++;
                continue;
            }
            if (char.IsLetter(symbols[i]) && char.IsUpper(symbols[i]))
            {
                int newLetter = symbols[i] + shift;

                symbols[i] =
                    newLetter > 90
                        ? BeyondTheBoundOfAlphabetMov(newLetter, 90, 64)
                        : (char)newLetter;

                shift++;
                continue;
            }
            shift++;
        }
        var encryptStr = new string(symbols);

        int arrItemLength = GetLength(encryptStr.Length);
        string[] result = new string[PIECE_FOR_EACH_RUNNER];

        int j = 0;
        for (int i = 0; i < encryptStr.Length; i++)
        {
            if (i % arrItemLength == 0 && i != 0)
            {
                j++;
            }
            result[j] += encryptStr[i];
        }

        List<string> strings = new List<string>();
        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] == null) result[i] = "";
            strings.Add(result[i]);
        }
        demovingShift(result.ToList(), primaryShift);
        return result.ToList();
    }

    public static int GetLength(int strLength)
    {
        while (strLength % 5 != 0)
        {
            strLength++;
        }
        return strLength / 5;
    }

    public static char BeyondTheBoundOfAlphabetMov(int value, int maxValue, int minValue)
    {
        while (value > maxValue)
        {
            value = minValue + (value - maxValue);
        }
        return (char)value;
    }

    public static string demovingShift(List<string> s, int shift)
    {
        string str = string.Join("", s);
        var symbols = str.ToCharArray();

        for (int i = 0; i < symbols.Length; i++)
        {
            if (char.IsLetter(symbols[i]) && char.IsLower(symbols[i]))
            {
                int newLetter = symbols[i] - shift;

                symbols[i] =
                    newLetter < 96
                        ? BeyondTheBoundOfAlphabetDemov(newLetter, 96, 122)
                        : (char)newLetter;

                shift++;
                continue;
            }
            if (char.IsLetter(symbols[i]) && char.IsUpper(symbols[i]))
            {
                int newLetter = symbols[i] - shift;

                symbols[i] =
                    newLetter < 64
                        ? BeyondTheBoundOfAlphabetDemov(newLetter, 64, 90)
                        : (char)newLetter;

                shift++;
                continue;
            }
            shift++;
        }
        return new string(symbols);
    }

    public static char BeyondTheBoundOfAlphabetDemov(int value, int minValue, int maxValue)
    {
        while (value < minValue)
        {
            value = maxValue - (minValue - value);
        }
        return (char)value;
    }
}
