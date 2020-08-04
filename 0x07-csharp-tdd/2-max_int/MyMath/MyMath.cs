using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Class for MAth operations
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// GEt Max int in list
        /// </summary>
        /// <param name="nums"></param>
        /// <returns>Max int</returns>
        public static int Max(List<int> nums)
        {
            if (nums.Count > 0)
            {
                nums.Sort();
                return (nums[nums.Count - 1]);
            }
            else
            {
                return (0);
            }
        }
    }
}
