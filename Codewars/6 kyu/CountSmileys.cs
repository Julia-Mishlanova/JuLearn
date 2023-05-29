public static class Kata
{
    public static int CountSmileys(string[] smileys)
    {
        int count = 0;
        for (int i = 0; i < smileys.Length; i++)
        {
            if (smileys[i].Length == 1) continue;

            if (smileys[i][0] != ';' && smileys[i][0] != ':') continue;
            if (smileys[i].Length == 3)
            {
                if (smileys[i][1] != '~' && smileys[i][1] != '-') continue;
                if (smileys[i][2] != ')' && smileys[i][2] != 'D') continue;
                count += 1;
            }
            if (smileys[i][1] != ')' && smileys[i][1] != 'D') continue;
            count += 1;
        }
        return count;
    }
}
