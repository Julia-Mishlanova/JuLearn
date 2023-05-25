using System;

public class Kata
{
  public static string HowMuchILoveYou(int nb_petals)
  {
            string loveWords = "I love";

            for (int i = 0; i < nb_petals; i++)
            {
                if (loveWords == "I love") loveWords = "I love you"; //0
                else if (loveWords == "I love you") loveWords = "a little";
                else if (loveWords == "a little") loveWords = "a lot";
                else if (loveWords == "a lot") loveWords = "passionately";
                else if (loveWords == "passionately") loveWords = "madly";
                else if (loveWords == "madly") loveWords = "not at all";
                else if (loveWords == "not at all") loveWords = "I love you";
            }
            return loveWords;
  }
}