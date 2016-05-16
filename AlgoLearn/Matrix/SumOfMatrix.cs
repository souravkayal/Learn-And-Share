using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class SumOfMatrixExceptCellRowColumn
    {
        /// <summary>
        /// The function will return sum of matrix except 
        /// row and column of given cell location
        /// </summary>
        /// <param name="Matrix"></param>
        /// <param name="Row"></param>
        /// <param name="Column"></param>
        /// <returns></returns>
        public int ReturnSumOfMatrix(int [,] Matrix , int Row, int Column , Tuple<int,int> Cell)
        {
            int Sum = 0;
            
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    if(Cell.Item1 != i && Cell.Item2 != j)
                        Sum += Matrix[i, j];
                }
            }
            return Sum;
        }
    }
}
