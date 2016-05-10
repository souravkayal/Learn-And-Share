using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndHash
{
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
