using System;

public class Solution
{
    public static int [] solve(String s)
    {
            int[] sumLet = new int[4];

            foreach (char ch in s)
            {
                if (Char.IsUpper(ch)) sumLet[0] += 1;
                else if (Char.IsLower(ch)) sumLet[1] += 1;
                else if (Char.IsDigit(ch)) sumLet[2] += 1;
                else sumLet[3] += 1;
            }
            return sumLet;
    }
}