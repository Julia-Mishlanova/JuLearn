using System.Collections.Generic;
using System.Linq;

public class SudokuValidator
{
    public static bool Validate(int[][] board)
    {
        if (WindowsWithErrors(board)) return false;

        int[][] verticalBoard = new int[9][];
        for (int i = 0; i < verticalBoard.Length; i++)
        {
            verticalBoard[i] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        }

        for (int i = 0; i < board.Length; i++)
            for (int j = 0; j < board[i].Length; j++)
            {
                verticalBoard[i][j] = board[j][i];
            }

        int[] cells = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        for (int i = 0; i < cells.Length; )
        {
            if (HasEqualQuantity(cells[i], board) == true
                && HasEqualQuantity(cells[i], verticalBoard) == true)
            {
                i++;
                continue;
            }
            if (HasEqualQuantity(cells[i], board) == false
                || HasEqualQuantity(cells[i], verticalBoard) == false) return false;
        }
        return true;
    }

    public static bool HasEqualQuantity(int cell, int[][] board)
    {
        List<int> index = new List<int>();
        for (int i = 0; i < board.Length; i++)
            for (int j = 0; j < board[i].Length; j++)
            {
                if (board[i][j] == 0) return false;

                if (board[i][j] == cell)
                {
                    if (index.Contains(j)) return false;
                    index.Add(j);
                }
            }
        return true;
    }

    public static bool WindowsWithErrors(int[][] board)
    {
        List<int> cells = new List<int>();

        for (int si = 0; si < board.Length; si += 3)
        {
            for (int sj = 0; sj < board.Length; sj += 3)
            {
                for (int i = si; i < si + 3; i++)
                    for (int j = sj; j < sj + 3; j++)
                    {
                        cells.Add(board[i][j]);
                    }

                IEnumerable<int> result = cells.Distinct();
                if (result.Count() != 9) return true;

                cells.Clear();
            }
        }
        return false;
    }
}
