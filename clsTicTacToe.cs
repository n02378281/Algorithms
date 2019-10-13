using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public class clsTicTacToe
    {
        /** Initialize your data structure here. */
        int diagonal = 0;
        int antidiagonal = 0;
        int[] rows;
        int[] cols;
        int n;

        public clsTicTacToe(int n)
        {
            this.n = n;
            rows = new int[n];
            cols = new int[n];
        }

        /** Player {player} makes a move at ({row}, {col}).
            @param row The row of the board.
            @param col The column of the board.
            @param player The player, can be either 1 or 2.
            @return The current winning condition, can be either:
                    0: No one wins.
                    1: Player 1 wins.
                    2: Player 2 wins. */
        public int Move(int row, int col, int player)
        {
            var num = 1;
            if (player == 2)
            {
                num = -1;
            }
            rows[col] += num;
            cols[row] += num;

            if (row == col)
            {
                diagonal += num;
            }

            if (row == n - col - 1)
            {
                antidiagonal += num;
            }

            if (rows[col] == n || cols[row] == n || diagonal == n || antidiagonal == n)
            {
                return 1;
            }
            else if (rows[col] == -n || cols[row] == -n || diagonal == -n || antidiagonal == -n)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
