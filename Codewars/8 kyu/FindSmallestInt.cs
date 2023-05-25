public class Kata 
{
    public static int FindSmallestInt(int[] args) 
    {
        int survivor = args[0];

        for (int i = 0; i < args.Length; i++)
        { 
            if (survivor > args[i])
            {
                survivor = args[i];
            }
        }
        return survivor;
    }
}