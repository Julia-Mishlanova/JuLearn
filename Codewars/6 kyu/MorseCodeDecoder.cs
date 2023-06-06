using System.Collections.Generic;

class MorseCodeDecoder
{
    public static string Decode(string morseCode)
    {
        Dictionary<string, string> map = new Dictionary<string, string>();
        var morse = new string[]
        {
            ".-",
            "-...",
            "-.-.",
            "-..",
            ".",
            "..-.",
            "--.",
            "....",
            "..",
            ".---",
            "-.-",
            ".-..",
            "--",
            "-.",
            "---",
            ".--.",
            "--.-",
            ".-.",
            "...",
            "-",
            "..-",
            "...-",
            ".--",
            "-..-",
            "-.--",
            "--..",
            "-.-.--",
            ".-.-.-"
        };
        var value = "ABCDEFGHIJKLMNOPQRSTUVWXYZ!.";

        map.Add("...---...", "SOS");
        for (int i = 0; i < morse.Length; i++)
        {
            map.Add(morse[i], value[i].ToString());
        }

        string message = "";
        bool flagSpace = false;
        List<string> code = new List<string>(morseCode.Split(' '));

        for (int i = 0; i < code.Count; i++)
        {
            if (map.ContainsKey(code[i]))
            {
                message += map[code[i]];
            }
            if (code[i] == "" && flagSpace == false)
            {
                message += " ";
                flagSpace = true;
            }
            if (code[i] == "" && flagSpace == true)
            {
                continue;
            }
            flagSpace = false;
        }
        if (message.Length == 0) return "SOS";
        return message.TrimEnd(' ').TrimStart(' ');
    }
}
