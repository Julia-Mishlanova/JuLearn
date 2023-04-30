class Kata
{
    public static string Bump(string input)
    {
            int countBumps = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'n') countBumps += 1;
            }
            return (countBumps <= 15) ? "Woohoo!" : "Car Dead";
    }
}