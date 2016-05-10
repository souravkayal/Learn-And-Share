using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndHash
{

//    Input: arr[] = {15, -2, 2, -8, 1, 7, 10, 23};
//Output: 5
//The largest subarray with 0 sum is -2, 2, -8, 1, 7

//Input: arr[] = {1, 2, 3}
//Output: 0
//There is no subarray with 0 sum

//Input: arr[] = {1, 0, 3}
//Output: 1

    public class MaxSubarrayForSum
    {
        public void FindMaxSubArray()
        {
            int[] Array = { 15, -2, 2, -8, 1, 7, 10, 23 };
            int max_length = 0;

            for (int i = 0; i < Array.Length; i++)
            {
                int CurrentSum = 0;
                for (int j = i; j < Array.Length; j++)
                {
                    CurrentSum += Array[j];
                    if (CurrentSum == 0)
                        max_length = Math.Max(max_length, j - 1 + 1);
                }
            }
            Console.WriteLine(max_length);
        }
    }
}
