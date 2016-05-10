using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndHashAlgo
{
    //Program to check whether two sets are disjoint or not
    //Input: set1[] = {12, 34, 11, 9, 3}
    //set2[] = {2, 1, 3, 5}
    //Output: Not Disjoint
    //3 is common in two sets.
    //Complexcity mXn

    public class CheckDisjointOrNot
    {
        public bool CheckWhetherTwoSetsAreDisjoint(int []Array1 , int []Array2)
        {
            for (int i = 0; i < Array1.Length; i++)
            {
                for (int j = 0; j < Array2.Length; j++)
                {
                    if (Array1[i] == Array2[j])
                        return false;
                }
            }
            return true;
        }
    }
}
