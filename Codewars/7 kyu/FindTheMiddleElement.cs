public class Kata
{
        public static int Gimme(double[] inputArray)
        {
            double[] nums = new double[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                nums[i] = inputArray[i];
            }
          
            double buff = 0;
            bool isSorting = false;
            while (!isSorting)
                for (int i = 0; i < inputArray.Length - 1; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        buff = nums[i + 1];
                        nums[i + 1] = nums[i];
                        nums[i] = buff;
                        isSorting = false;
                        break;
                    }
                    isSorting = true;
                }
            return GetIndex(nums, inputArray);
        }

        public static int GetIndex(double[] nums, double[] inputArray) 
        { 
            double element = nums[1];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == element) return i;
            }
            return 0;
        }
}