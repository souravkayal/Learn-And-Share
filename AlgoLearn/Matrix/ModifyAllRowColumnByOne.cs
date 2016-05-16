using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class ModifyAllRowColumnByOne
    {
        /// <summary>
        /// The function will set row and column to 1 if it finds 1 in corresponding cell
        /// So, If A[1,1] = 1 then it will set 1 in 1st row and column 
        /// </summary>
        List<int> Index = new List<int>();

        public void ModifyMatrix(int [,]Matrix , int Row, int Column)
        {
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    if (Matrix[i, j] == 1)
                    {
                        Index.Add(i);
                        Index.Add(j);
                    }
                }
            }

            for (int i = 0; i < Index.Count; i = i + 2)
            {
                for (int j = 0; j < Row; j++)
                {
                    for (int k = 0; k < Column; k++)
                    {
                        if (Index[i] == j || k == Index[i + 1])
                            Matrix[j, k] = 1;
                    }
                }
            }
            //Print Modified Matrix

            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    System.Console.Write(Matrix[i, j]+ " ");
                }
                System.Console.WriteLine();
            }


        }
    }
}
