using System;

public static class Kata 
{
    public static int CountSalutes(string hallway)
    {
            bool people = false;
            int countPeople = 0;
            int countSalutes = 0;

            for (int i = 0; i < hallway.Length; i++)
            {
                if (hallway[i] == '>') 
                { 
                    people = true; 
                    countPeople++;
                }
                if (people == true && hallway[i] == '<') countSalutes += 2 * countPeople;
            }
            return countSalutes;
    }
}