using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    class ArrRotateImage
    {
        public void Rotate(int[][] matrix)
        {
            int size = 3;
            int[,] result = new int[size, size];

            for (int i = 2; i >= 0; i--)
            {
                for (int j = 0; j < size; j++)
                {
                    result[j, i] = matrix[i - 2][j];
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i][j] = result[i, j];
                }
            }
        }
    }
}
