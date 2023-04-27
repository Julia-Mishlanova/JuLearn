using System.Collections.Generic;

public class Kata
 {
    public static string AlphabetWar(string fight)
    {
            var anotherSide = new Dictionary<string, int>();
            var keyAnoth = "acefghijklnortuvxy";

            var leftSide = new Dictionary<string, int>();
            var keyLeft = "sbpw";
            var valueLeft = 1;

            var rightSide = new Dictionary<string, int>();
            var keyRigth = "zdqm";
            var valueRigth = 1;

            for (int i = 0; i < 4; i++)
            {
                leftSide.Add(keyLeft[i].ToString(), valueLeft++);
                rightSide.Add(keyRigth[i].ToString(), valueRigth++);
                anotherSide.Add(keyAnoth[i].ToString(), 0);
            }

            int power = 0;
            for (int i = 0; i < fight.Length; i++)
            {
                if (leftSide.ContainsKey(fight[i].ToString())) power += leftSide[fight[i].ToString()];
                else if (rightSide.ContainsKey(fight[i].ToString())) power -= rightSide[fight[i].ToString()];
                else if (anotherSide.ContainsKey(fight[i].ToString())) power += 0;
            }
            return (power == 0) ? "Let's fight again!" : (power > 0) ? "Left side wins!" : "Right side wins!";
    }
 }