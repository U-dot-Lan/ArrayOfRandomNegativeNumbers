using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ArrayOfRandomNegativeNumbers
{
    public static class ArrayValues
    {
        public static void FillArray(int[] nums)
        {
            Random rand = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(-5, 6);
            }
        }

        public static int[] FindNegativeNumbers(int[] nums)
        {
            return nums.Where(i => i < 0).ToArray();
        }

        public static void SortArray(int[] nums)
        {
            for (var i = 0; i < nums.Length / 2; i++)
            {
                var swapFlag = false;
                for (var j = i; j < nums.Length - i - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int t = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = t;
                        swapFlag = true;
                    }
                }
                for (var j = nums.Length - 2 - i; j > i; j--)
                {
                    if (nums[j - 1] > nums[j])
                    {
                        int t = nums[j];
                        nums[j] = nums[j - 1];
                        nums[j - 1] = t;
                        swapFlag = true;
                    }
                }
                if (!swapFlag)
                {
                    break;
                }
            }
        }
    }
}
