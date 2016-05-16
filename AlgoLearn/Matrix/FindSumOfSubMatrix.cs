using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class FindSumOfSubMatrix
    {
        public int FindSumOfSubMatrixWithCellBoundary(int [,] Matrix , int Row, int Column , Tuple<int,int> CellValue)
        {
            int Sum = 0;
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    if (i <= CellValue.Item1 && j <= CellValue.Item2)
                        Sum += Matrix[i, j];    
                }
            }
            return Sum;
        }
    }
}
