using System.Collections.Generic;

public class Kata
{
    public static bool IsValidWalk(string[] walk)
    {
        if (walk.Length != 10) return false;

        int counter = 0;
        for (int i = 0; i < walk.Length; i++)
        {
            if (walk[i] == "n" || walk[i] == "w") counter += 1;
            if (walk[i] == "s" || walk[i] == "e") counter -= 1;
        }

        if (walk[0] == "n" && walk[walk.Length - 1] != "s") return false;
        if (walk[0] == "s" && walk[walk.Length - 1] != "n") return false;

        if (walk[0] == "w" && walk[walk.Length - 1] != "e") return false;
        if (walk[0] == "e" && walk[walk.Length - 1] != "w") return false;

        return counter == 0;
    }
}
