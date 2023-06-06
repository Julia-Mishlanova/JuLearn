using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Kata
{
    public static string DrawPattern(int[] waves)
    {
        int max = 0;
        for (int i = 0; i < waves.Length; i++)
        {
            if (max < waves[i]) max = waves[i];
        }

        List<string> layers = new List<string>();
        layers.Add(GetStartLayer(waves, max));

        for (int i = max - 2; i >= 0; i--)
        {
            layers.Add(GetLayer(layers[layers.Count - 1], i + 1, waves));
        }

        StringBuilder result = new StringBuilder();
        foreach (var layer in layers)
        {
            result.Append(layer + '\n');
        }
        return result.ToString().TrimEnd('\n');
    }

    public static string GetStartLayer(int[] waves, int max)
    {
        string startLayer = "";
        for (int i = 0; i < waves.Length; i++)
        {
            if (waves[i] == max)
            {
                startLayer += '■';
                continue;
            }
            startLayer += '□';
        }
        return startLayer;
    }

    public static string GetLayer(string prevResult, int point, int[] waves)
    {
        var chars = prevResult.ToCharArray();
        for (int i = 0; i < waves.Length; i++)
        {
            if (waves[i] == point)
            {
                chars[i] = '■';
            }
        }
        return new string(chars);
    }
}
