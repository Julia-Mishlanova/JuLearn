public class Dinglemouse 
{

   public static int[] HumanYearsCatYearsDogYears(int humanYears) 
   {
        int catYears = 0;
        int dogYears = 0;

        if (humanYears == 1)
        {
            int a = catYears + 15;
            int b = dogYears + 15;
            return new int[] { humanYears, a, b };
        }
        else if (humanYears == 2)
        {
            int c = 15 + 9;
            int d = 15 + 9;
            return new int[] { humanYears, c, d };
        }

        if (humanYears >= 3)
        {
            int f = humanYears - 2;
            int g = (f * 4) + 15 + 9;
            int h = (f * 5) + 15 + 9;
            return new int[] { humanYears, g, h };
        }
        return new int[] { 0, 0, 0 };
   }
}