using System;
using System.Collections.Generic;
using System.Linq;

public class DirReduction
{
    public static string[] DirectionsReduction(String[] arr)
    {
        Dictionary<string, string> oppositeDir = new Dictionary<string, string>()
        {
            { "NORTH", "SOUTH" },
            { "SOUTH", "NORTH" },
            { "EAST", "WEST" },
            { "WEST", "EAST" },
        };

        List<string> simplifiedDir = new List<string>();
        foreach (var direction in arr)
        {
            if (simplifiedDir.LastOrDefault() == oppositeDir[direction])
            {
                simplifiedDir.RemoveAt(simplifiedDir.Count - 1);
            }
            else
            {
                simplifiedDir.Add(direction);
            }
        }
        return simplifiedDir.ToArray();
    }
}
