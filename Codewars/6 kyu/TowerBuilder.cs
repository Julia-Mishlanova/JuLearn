namespace Codewars
{
    public class Kata
    {
        public static string[] TowerBuilder(int nFloors)
        {
            string[] pyramid = new string[nFloors];
            string firstFloor = "";

            for (int i = 0; i < nFloors; i++)
            {
                if (i == 0)
                {
                    firstFloor += "*";
                    continue;
                }
                firstFloor += "**";
            }

            int count = 0;
            for (int i = nFloors - 1; i >= 0; i--)
            {
                if (i == nFloors - 1)
                {
                    pyramid[i] += firstFloor;
                    count++;
                    continue;
                }
                pyramid[i] += GetFloor(count, firstFloor);
                count++;
            }
            return pyramid;
        }

        public static string GetFloor(int count, string floor)
        {
            var result = floor.ToCharArray();
            int length = floor.Length;
            for (int i = length - 1; i >= length - count; i--)
            {
                result[i] = ' ';
            }

            for (int i = 0; i < count; i++)
            {
                result[i] = ' ';
            }
            return new string(result);
        }
    }
}
