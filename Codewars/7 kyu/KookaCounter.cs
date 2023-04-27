public class Dinglemouse
{
  public static int KookaCounter(string laughing)
  {
            if (laughing.Length == 0) return 0;

            string birds = "";
            for (int i = 0; i < laughing.Length; i++)
            {
                if (laughing[i] != 'a') birds += laughing[i];
            }

            int countOfBirds = 0;
            int firstBird = 1;
            for (int i = 0; i < birds.Length - 1; i++)
            {
                if (birds[i] != birds[i + 1]) countOfBirds += 1;
            }
            return firstBird + countOfBirds;
  }
}