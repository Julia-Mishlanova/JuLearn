public class Kata
{
  public static string SortGiftCode(string code)
  {
            var letter = code.ToCharArray();

            char buff = ' ';
            bool isSorting = false;
            while (!isSorting)
                for (int i = 0; i < letter.Length - 1; i++)
                {
                    if (letter[i] > letter[i+1])
                    {
                        buff = letter[i+1];
                        letter[i+1] = letter[i];
                        letter[i] = buff;
                        isSorting = false;
                            break;
                    }
                    else isSorting = true;
                }
            return new string(letter);
  }
}