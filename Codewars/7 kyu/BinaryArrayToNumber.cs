namespace Solution
{
  class Kata
    {
        public static int BinaryArrayToNumber(int[] binaryArray)
        {
            int result = 0;

            foreach (var bit in binaryArray)
            {
                result <<= 1;
                result |= bit;
            }
            return result;
        }
    }
}