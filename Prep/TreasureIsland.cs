using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    /* You have a map that marks the location of a treasure island. 
     * Some of the map area has jagged rocks and dangerous reefs. Other areas are safe to sail in. 
     * There are other explorers trying to find the treasure. So you must figure out a shortest route to the treasure island.
       Assume the map area is a two dimensional grid, represented by a matrix of characters. 
      You must start from the top-left corner of the map and can move one block up, down, left or right at a time.
      The treasure island is marked as X in a block of the matrix. X will not be at the top-left corner. 
      Any block with dangerous rocks or reefs will be marked as D. You must not enter dangerous blocks. 
    You cannot leave the map area. 
    Other areas O are safe to sail in. The top-left corner is always safe.
    Output the minimum number of steps to get to the treasure.
    Input:
     [['O', 'O', 'O', 'O'],
      ['D', 'O', 'D', 'O'],
      ['O', 'O', 'O', 'O'],
      ['X', 'D', 'D', 'O']]

Output: 5
Explanation: Route is (0, 0), (0, 1), (1, 1), (2, 1), (2, 0), (3, 0) The minimum route takes 5 steps.
    */

    public class TreasureIsland
    {
        public class Coordinate
        {
            public int _x;
            public int _y;

            public Coordinate(int x, int y)
            {
                this._x = x;
                this._y = y;
            }
        }
        public static int treasureIsland(char[][] island)
        {
            if (island == null || island.Length == 0) return 0;

            int steps = 0;
            Queue<Coordinate> queue = new Queue<Coordinate>();
            queue.Enqueue(new Coordinate(0, 0));
            bool[][] visited = new bool[island.Length][];
            visited[0][0] = true;
            int[][] dirs = { new int[] { 1, 0 }, new int[] { -1, 0 }, new int[] { 0, 1 }, new int[] { 0, -1 } };

            // bfs
            while (queue.Count > 0)
            {

                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    Coordinate coordinate = queue.Dequeue();
                    int x = coordinate._x ;
                    int y = coordinate._y;
                    if (island[x][y] == 'X') return steps;

                    foreach (int[] dir in dirs)
                    {
                        int newX = x + dir[0];
                        int newY = y + dir[1];

                        if (newX >= 0 && newX < island.Length && newY >= 0 && newY < island[0].Length &&
                                island[newX][newY] != 'D' && !visited[newX][newY])
                        {
                            queue.Enqueue(new Coordinate(newX, newY));
                            visited[newX][newY] = true;
                        }
                    }
                }
                steps++;
            }

            return 0;

        }
    }

}
