using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndHash
{

    //    Count pairs with given sum
    //Given an array of integers, and a number ‘sum’, find the number of pairs of integers in the array whose sum is equal to sum.

    //Examples:
    //Input  :  arr[] = {1, 5, 7, -1}, 
    //          sum = 6
    //Output :  2

    public class CountPairWithGivenSum
    {
        public int ReturnPair(int []Array , int Sum)
        {
            int CountPair = 0;

            for (int i = 0; i < Array.Length ; i++)
            {
                for (int j = i + 1 ; j < Array.Length ; j++)
                {
                    if (Array[i] + Array[j] == Sum)
                        CountPair += 1;
                }
            }

            return CountPair;
        }
    }
}
