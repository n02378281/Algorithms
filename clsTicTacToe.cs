using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public class clsTicTacToe
    {
        public int[] rw;
        public int[] cl;
        public int diag;
        public int nonDiag;
        public int length;
        public clsTicTacToe(int n)
        {
            rw = new int[n];
            cl = new int[n];
            diag = 0;
            nonDiag = 0; length = n;
        }

        public int Move(int row, int col, int player)
        {
            var val = (player == 1) ? 1 : -1;
            rw[row] += val;
            cl[col] += val;
            if (row == col)
                diag += val;
            if (row + col == (length - 1))
                nonDiag = val;
            if (rw[row] == length || cl[col] == length || diag == length || nonDiag == length)
            {
                return 1;
            }
            if (rw[row] == -length || cl[col] == -length || diag == -length || nonDiag == -length)
            {
                return 1;
            }
            return 0;
        }
    }
}
