using System;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static int[] bubbleSort(int[] nums)
        {
            int temp;
            for (int i = 0; i < nums.Length -1; i++){
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        //swap nums[j] and nums[j + 1]
                        temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }

            return nums;
        }
    }
}
