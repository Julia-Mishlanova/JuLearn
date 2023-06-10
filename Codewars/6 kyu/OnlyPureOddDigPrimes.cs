using System.Collections.Generic;

public class OddDigPrime
{
    public static long[] OnlyPureOddDigPrimes(long n)
    {
        var listOfDigit = OddDigPrimes(n);
        long oddPrime = FirstNumberAfterN(n);
        var result = new long[] { listOfDigit.Count, listOfDigit[listOfDigit.Count - 1], oddPrime };
        return result;
    }

    public static List<long> OddDigPrimes(long number)
    {
        List<long> listOfDigit = new List<long>();
        for (long i = 3; i < number; i++)
        {
            if (IsPrime(i) == true && checkIndexOdd(i) == false) listOfDigit.Add(i);
        }
        return listOfDigit;
    }

    public static bool IsPrime(long number)
    {
        long sqrt = (long)System.Math.Sqrt(number);
        for (int i = 3; i <= sqrt; i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    public static bool checkIndexOdd(long index)
    {
        string num = index.ToString();

        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] == '2' 
                || num[i] == '4' 
                || num[i] == '6' 
                || num[i] == '8' 
                || num[i] == '0') return true;
        }
        return false;
    }

    public static long FirstNumberAfterN(long n)
    {
        long oddPrime = n;
        while (IsPrime(oddPrime) == false || checkEven(oddPrime) == true)
        {
            oddPrime++;
        }
        return oddPrime;
    }

    public static bool checkEven(long number)
    {
        string num = number.ToString();

        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] == '2' 
                || num[i] == '4' 
                || num[i] == '6' 
                || num[i] == '8' 
                || num[i] == '0') return true;
        }
        return false;
    }
}
