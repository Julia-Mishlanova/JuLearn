public class Kata
{
    public static string WhatCentury(string year)
    {
        int lastNumOfYear = int.Parse(year.Substring(year.Length - 2));
        int firstTwoNums = int.Parse(year.Substring(0, 2));
        int result = lastNumOfYear == 0 ? firstTwoNums : firstTwoNums + 1;
        string century = result.ToString();

        if (result >= 10 && result <= 19) return result + "th";

        int lastNumOfCentury = int.Parse(century.Substring(century.Length - 1));

        if (lastNumOfCentury == 1) return century + "st";
        if (lastNumOfCentury == 2) return century + "nd";
        if (lastNumOfCentury == 3) return century + "rd";

        return result + "th";
    }
}
