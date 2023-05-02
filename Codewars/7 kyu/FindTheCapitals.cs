using System.Collections.Generic;

public static class Kata
{
  public static int[] Capitals(string word)
  {
		    List<int> listOfInd = new List<int>();
            for (int i = 0; i < word.Length; i++)
            {
                if ((byte)word[i] >= 65 && (byte)word[i] <= 90)
                {
                    listOfInd.Add(i);
                }
            }
            return listOfInd.ToArray();
  }
}