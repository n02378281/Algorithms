using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    public class ArrSpiralMatrix
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            IList<int> result = new List<int>();
            if (matrix.Length == 0) return result;
            int top = 0;
            int bottom = matrix.GetLength(0) - 1;
            int left = 0;
            int right = matrix[0].Length - 1;
            int dir = 0;
            while (top <= bottom && left <= right)
            {
                //Traverse right
                if (dir == 0)
                {
                    for (int i = left; i <= right; i++) result.Add(matrix[top][i]);
                    top++;
                }
                //Traverse top to bottom
                else if (dir == 1)
                {
                    for (int i = top; i <= bottom; i++) result.Add(matrix[i][right]);
                    right--;
                }
                //Traverse left
                else if (dir == 2)
                {
                    for (int i = right; i >= left; i--) result.Add(matrix[bottom][i]);
                    bottom--;
                }
                else if (dir == 3)
                {
                    for (int i = bottom; i >= top; i--) result.Add(matrix[i][left]);
                    left++;
                }
                dir = (dir + 1) % 4;
            }
            return result;
        }
    }
}
