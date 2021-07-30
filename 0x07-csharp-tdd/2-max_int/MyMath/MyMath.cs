using System;
using System.Collections.Generic;

namespace MyMath
{
    public class Operations
    {
        public static int Max(List<int> nums)
        {
            if (nums != null && nums.Count > 0)
            {
                int max = nums[0];
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] > max)
                        max = nums[i];
                }
                return max;
            }
            return 0;
        }
    }
}
