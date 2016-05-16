using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    
    public class RowWithMaximumOne
    {
        /// <summary>
        /// Function to return row where maximum number of one is there
        /// </summary>
        public int ReturnRowWithMaximumOne(int Row, int Column , int[,] Array)
        {
            int RowIndex = 0;
            int ItemCount = 0;

            for (int i = 0; i < Row; i++)
            {
                int TmpItemCount = 0;
                for (int j = 0; j < Column; j++)
                {
                    if (Array[i, j] == 1)
                        TmpItemCount += 1;
                }
                if (TmpItemCount > ItemCount)
                    RowIndex = i;
                    ItemCount = TmpItemCount;
            }

            return RowIndex;
        }

    }
}
