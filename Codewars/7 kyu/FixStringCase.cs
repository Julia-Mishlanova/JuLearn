class Kata
{
    public static string Solve(string s)
    {
            int countLow = 0;
            int countUp = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ((byte)s[i] >= 97 && (byte)s[i] <= 122) countLow += 1;
                if ((byte)s[i] >= 65 && (byte)s[i] <= 90) countUp += 1;
            }

            if (countUp > countLow) return s.ToUpper();
            if (countLow > countUp) return s.ToLower();
            if (countLow == countUp) return s.ToLower();
            return s;
    }
}