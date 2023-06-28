using System;
using System.Text;

public class Kata
{
    public static string DisplayBoard(char[] board, int width)
    {
        StringBuilder result = new StringBuilder();
        string buffLine = string.Empty;

        int wallLength = width + (width * 2) + (width - 1);
        string wall = new string('-', wallLength);

        int counter = 0;
        for (int i = 0; i < board.Length; i++)
        {
            if (counter == width)
            {
                buffLine = buffLine.TrimEnd('|');

                result.Append(buffLine + '\n');
                result.Append(wall + '\n');

                buffLine = string.Empty;
                counter = 0;
            }
            buffLine += string.Format(" {0} |", board[i]);
            counter++;
        }
        result.Append(buffLine.TrimEnd('|'));
        return result.ToString();
    }
}
