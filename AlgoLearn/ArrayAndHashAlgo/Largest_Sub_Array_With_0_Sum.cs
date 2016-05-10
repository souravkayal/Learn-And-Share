using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndHashAlgo
{
    public class Largest_Sub_Array_With_0_Sum
    {
        public int ReturnLargestSubArray(int []Array)
        {
            int max_array = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                int sum = 0;
                for (int j = i ; j < Array.Length; j++)
                {
                    sum = sum + Array[j];
                    if (sum == 0)
                        max_array = Math.Max(max_array, j - i + 1);
                }
            }
            return max_array;
        }
    }
}
