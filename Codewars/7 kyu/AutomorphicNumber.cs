using System;

class Kata
{
    public static string Automorphic(int n)
    {
            double pow = Math.Pow(n, 2);

            string num = n.ToString();
            string powToStr = pow.ToString();
            string pieceOfPow = powToStr.Substring(powToStr.Length - num.Length);

            return (pieceOfPow != num) ? "Not!!" : "Automorphic";
    }
}