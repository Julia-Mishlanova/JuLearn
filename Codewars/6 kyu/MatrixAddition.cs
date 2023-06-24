public class Kata
{
    public static int[][] MatrixAddition(int[][] a, int[][] b)
    {
        int[][] result = new int[a.Length][];

        for (int y = 0; y < a.Length; y++)
            for (int x = 0; x < a[y].Length; x++)
            {
                result[y] = a[y];
                result[y][x] = a[y][x] + b[y][x];
            }
        return result;
    }
}
