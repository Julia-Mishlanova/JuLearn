using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QRCode
{
    public class Encoder
    {
        const string Alphanumeric = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ $%*+-./:";

        public static string Encode(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                if (!Alphanumeric.Contains(message[i]))
                {
                    return "0100" + ByteMode(message);
                }
            }

            for (int i = 0; i < message.Length; i++)
            {
                if (char.IsLetter(message[i]))
                {
                    return "0010" + AlphanumericMode(message);
                }
            }
            return "0001" + NumericMode(message);
        }

        public static string ConvertToBinary(int val, int bit)
        {
            string s = Convert.ToString(val, 2);
            return s.PadLeft(bit, '0');
        }

        public static string[] SplitIntoGroups(string message, int countSymbols)
        {
            var length = message.Length / countSymbols;
            if (message.Length % countSymbols != 0)
                length++;

            string[] groups = new string[length];
            int j = 0;
            for (int i = 0; i < message.Length; i++)
            {
                groups[j] += message[i];
                if (groups[j].Length == countSymbols) j++;
            }
            return groups;
        }

        public static string ByteMode(string message)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ConvertToBinary(message.Length, 8));

            for (int i = 0; i < message.Length; i++)
            {
                int charValue = message[i];
                sb.Append(ConvertToBinary(charValue, 8));
            }
            return sb.ToString();
        }

        public static string AlphanumericMode(string message)
        {
            string[] groups = SplitIntoGroups(message, 2);

            StringBuilder sb = new StringBuilder();
            sb.Append(ConvertToBinary(message.Length, 9));

            var lastGroup = groups[groups.Length - 1];
            var loopLength = lastGroup.Length == 1 ? groups.Length - 1 : groups.Length;

            for (int i = 0; i < loopLength; i++)
            {
                int firstItem = Alphanumeric.IndexOf(groups[i][0]);
                int secondItem = Alphanumeric.IndexOf(groups[i][1]);
                int val = firstItem * 45 + secondItem;

                sb.Append(ConvertToBinary(val, 11));
            }

            if (lastGroup.Length == 1)
            {
                int item = Alphanumeric.IndexOf(lastGroup);
                sb.Append(ConvertToBinary(item, 6));
            }
            return sb.ToString();
        }

        public static string NumericMode(string message)
        {
            List<string> groups = SplitIntoGroups(message, 3).ToList();

            for (int i = 0; i < groups.Count; i++)
            {
                groups[i] = groups[i].TrimStart('0');
                groups[i] = groups[i].TrimStart('0');
                groups[i] = groups[i].TrimStart('0');
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(ConvertToBinary(message.Length, 10));
            for (int i = 0; i < groups.Count; i++)
            {
                int num = int.Parse(groups[i]);
                if (groups[i].Length == 3) sb.Append(ConvertToBinary(num, 10));
                else if (groups[i].Length == 2) sb.Append(ConvertToBinary(num, 7));
                else if (groups[i].Length == 1) sb.Append(ConvertToBinary(num, 4));
                else sb.Append("0000");
            }
            return sb.ToString();
        }
    }
}
