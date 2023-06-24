using System.Collections.Generic;

static class Kata
{
    public static string MakeAWindow(int num)
    {
        List<string> layers = new List<string>();

        int frameLength = num + num + 3;
        string frame = new string('-', frameLength);

        string glass = new string('.', num);
        string partOfBar = string.Format("|{0}|{1}|", glass, glass);

        layers.Add(frame);
        for (int i = 0; i < num; i++)
        {
            layers.Add(partOfBar);
        }

        string bar = new string('-', num);
        string specialLayer = string.Format("|{0}+{1}|", bar, bar);
        layers.Add(specialLayer);

        for (int i = 0; i < num; i++)
        {
            layers.Add(partOfBar);
        }
        layers.Add(frame);

        return string.Join("\n", layers);
    }
}
