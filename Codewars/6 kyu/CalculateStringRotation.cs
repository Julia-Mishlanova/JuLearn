using System;

public class CalculateStringRotation
{
    public static int ShiftedDiff(string first, string second)
    {
        if (StringsContainDifferentLetters(first, second)) return -1;

        string rotateFirst = first;
        int iterationCount = 0;

        while (rotateFirst != second)
        {
            rotateFirst = Rotation(rotateFirst.ToString());
            iterationCount++;

            if (iterationCount == 100)
            {
                iterationCount = -1;
                break;
            }
        }
        return iterationCount;
    }

    public static string Rotation(string str)
    {
        char buff = str[str.Length - 1];
        var result = str.ToCharArray();

        for (int i = result.Length - 1; i > 0; i--)
        {
            result[i] = result[i - 1];
        }

        result[0] = buff;
        return new string(result);
    }

    public static bool StringsContainDifferentLetters(string first, string second)
    {
        if (first.Length != second.Length) return true;
        
        var firstSortArr = first.ToCharArray();
        var secondSortArr = second.ToCharArray();

        Array.Sort(firstSortArr);
        Array.Sort(secondSortArr);

        for (int i = 0; i < firstSortArr.Length; i++)
        {
            if (firstSortArr[i] != secondSortArr[i]) return true;
        }

        return false;
    }
}
