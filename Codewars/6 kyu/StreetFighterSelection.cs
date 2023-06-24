using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public string[] StreetFighterSelection(string[][] fighters, int[] position, string[] moves)
    {
        List<string> selected = new List<string>();
        int lastCharacter = fighters[0].Length - 1;

        int curPosX = 0;
        int curPosY = 0;

        foreach (var move in moves)
        {
            if (move == "down")
            {
                curPosY = (curPosY == fighters.Length - 1) ? curPosY : +1;
                selected.Add(fighters[curPosY][curPosX]);
                continue;
            }

            if (move == "up")
            {
                curPosY = (curPosY == 0) ? curPosY : curPosY -= 1;
                selected.Add(fighters[curPosY][curPosX]);
                continue;
            }

            if (move == "right" && curPosX != lastCharacter)
            {
                curPosX++;
                selected.Add(fighters[curPosY][curPosX]);
                continue;
            }

            if (move == "right" && curPosX == lastCharacter)
            {
                curPosX = 0;
                selected.Add(fighters[curPosY][curPosX]);
                continue;
            }

            if (move == "left" && curPosX != lastCharacter && curPosX != 0)
            {
                curPosX--;
                selected.Add(fighters[curPosY][curPosX]);
                continue;
            }

            if (move == "left" && curPosX == lastCharacter)
            {
                curPosX--;
                selected.Add(fighters[curPosY][curPosX]);
                continue;
            }

            if (move == "left" && curPosX == 0)
            {
                curPosX = lastCharacter;
                selected.Add(fighters[curPosY][curPosX]);
                continue;
            }
            else
                break;
        }
        return selected.ToArray();
    }
}
