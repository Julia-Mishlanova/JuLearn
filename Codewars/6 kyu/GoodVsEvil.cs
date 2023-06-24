using System;

public class Kata
{
    public static string GoodVsEvil(string good, string evil)
    {
        int g = 0;
        var forcesOfGood = new int[] { 1, 2, 3, 3, 4, 10 };
        var countOfGood = good.Split(' ');
        
        for (int i = 0; i < forcesOfGood.Length; i++)
        {
            if (countOfGood[i] == "0") continue;

            g += forcesOfGood[i] * int.Parse(countOfGood[i]);
        }

        int e = 0;
        var forcesOfEvil = new int[] { 1, 2, 2, 2, 3, 5, 10 };
        var countOfEvil = evil.Split(' ');
        for (int i = 0; i < forcesOfEvil.Length; i++)
        {
            if (countOfEvil[i] == "0") continue;

            e += forcesOfEvil[i] * int.Parse(countOfEvil[i]);
        }
        if (g == e) return "Battle Result: No victor on this battle field";

        return g > e
            ? "Battle Result: Good triumphs over Evil"
            : "Battle Result: Evil eradicates all trace of Good";
    }
}
