using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    public static class RottingOranges
    {
        public static int OrangesRotting(int[][] grid)
        {
            var queue = Init(grid, out int freshCount);
            int minutes = 0;

            while (queue.Count > 0 && freshCount > 0)
            {
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    Enqueue(grid, queue, ref freshCount);
                }
                minutes++;
            }

            Console.WriteLine("{0}", minutes);
            return freshCount == 0 ? minutes : -1;
        }

        private static Queue<(int, int)> Init(int[][] grid, out int freshCount)
        {
            var queue = new Queue<(int, int)>();
            freshCount = 0;

            for (int x = 0; x < grid.Length; x++)
            {
                for (int y = 0; y < grid[0].Length; y++)
                {
                    if (grid[x][y] == 2)
                    {
                        queue.Enqueue((x, y));
                    }
                    if (grid[x][y] == 1)
                    {
                        freshCount++;
                    }
                }
            }
            return queue;
        }

        private static void Enqueue(int[][] grid, Queue<(int, int)> queue, ref int freshCount)
        {
            (int x, int y) = queue.Dequeue();

            if (x > 0 && grid[x - 1][y] == 1)
            {
                grid[x - 1][y] = 2;
                freshCount--;
                queue.Enqueue((x - 1, y));
            }
            if (y > 0 && grid[x][y - 1] == 1)
            {
                grid[x][y - 1] = 2;
                freshCount--;
                queue.Enqueue((x, y - 1));
            }
            if (x + 1 < grid.Length && grid[x + 1][y] == 1)
            {
                grid[x + 1][y] = 2;
                freshCount--;
                queue.Enqueue((x + 1, y));
            }
            if (y + 1 < grid[0].Length && grid[x][y + 1] == 1)
            {
                grid[x][y + 1] = 2;
                freshCount--;
                queue.Enqueue((x, y + 1));
            }
        }


        public class Point
        {
            public int r, c;

            public Point(int r, int c)
            {
                this.r = r;
                this.c = c;
            }
        }

        private static int[][] DIRS = { new int[] { 1, 0 }, new int[] { 0, 1 }, new int[] { -1, 0 }, new int[] { 0, -1 } };
        private static bool isSafe(char[][] grid, int r, int c)
        {
            return r >= 0 && r < grid.Length && c >= 0 && c < grid[0].Length && grid[r][c] != 'D';
        }

        public static int minSteps(char[][] grid)
        {
            Queue<Point> q = new Queue<Point>();
            q.Enqueue(new Point(0, 0));
            grid[0][0] = 'D';
            // mark as visited
            for (int steps = 1; q.Count > 0; steps++)
            {
                for (int sz = q.Count; sz > 0; sz--)
                {
                    Point p = q.Dequeue();

                    foreach (int[] dir in DIRS)
                    {
                        int r = p.r + dir[0];
                        int c = p.c + dir[1];

                        if (isSafe(grid, r, c))
                        {
                            if (grid[r][c] == 'X')
                                return steps;
                            grid[r][c] = 'D';
                            q.Enqueue(new Point(r, c));
                        }
                    }
                }
            }
            return -1;
        }


        private static int EMPTY = Int32.MaxValue;
        private static int GATE = 0;
        private static List<int[]> DIRECTIONS = new List<int[]>(){
                new int[] { 1, 0 },
                new int[] { -1, 0 },
                new int[] { 0, 1 },
                new int[] { 0, -1 }
        };

        public static void WallsAndGates(int[][] rooms)
        {
            int m = rooms.Length;
            if (m == 0) return;
            int n = rooms[0].Length;
            Queue<int[]> q = new Queue<int[]>();
            for (int row = 0; row < m; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (rooms[row][col] == GATE)
                    {
                        q.Enqueue(new int[] { row, col });
                    }
                }
            }
            while (q.Count > 0)
            {
                int[] point = q.Dequeue();
                int row = point[0];
                int col = point[1];
                foreach (int[] direction in DIRECTIONS)
                {
                    int r = row + direction[0];
                    int c = col + direction[1];
                    if (r < 0 || c < 0 || r >= m || c >= n || rooms[r][c] != EMPTY)
                    {
                        continue;
                    }
                    rooms[r][c] = rooms[row][col] + 1;
                    q.Enqueue(new int[] { r, c });
                }
            }
        }
    }
}
