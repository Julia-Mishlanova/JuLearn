using System.Collections.Generic;

public class Consecutives
{
    public static List<int> SumConsecutives(List<int> nums)
    {
        int sum = 0;
        List<int> result = new List<int>();
        for (int i = 0; i < nums.Count - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                sum += nums[i];
                while (nums[i] == nums[i + 1])
                {
                    i++;
                    sum += nums[i];
                }

                result.Add(sum);
                sum = 0;
                continue;
            }
            result.Add(nums[i]);
        }
        result.Add(nums[nums.Count - 1]);
        return result;
    }
}
