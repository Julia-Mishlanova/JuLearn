using System;

public class Kata
{
    public static Tuple<int, int> MineLocation(int[,] field)
    {
        var tuple = (0, 0);
        for (int i = 0; i < field.GetLength(0); i++)
            for (int j = 0; j < field.GetLength(1); j++)
            {
                if (field[i, j] != 0)
                {
                    tuple.Item1 = i;
                    tuple.Item2 = j;
                    break;
                }
            }
        return tuple.ToTuple();
    }
}
