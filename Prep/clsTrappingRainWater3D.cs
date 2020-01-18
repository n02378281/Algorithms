using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{    
    class clsTrappingRainWater3D
    {
        private struct Cell : IEquatable<Cell>, IComparable<Cell>
        {
            public readonly int Height;
            public readonly int RowIdx;
            public readonly int ColumnIdx;

            public Cell(int height, int rowIdx, int columnIdx)
            {
                Height = height;
                RowIdx = rowIdx;
                ColumnIdx = columnIdx;
            }

            public override bool Equals(object obj)
            {
                return Equals((Cell)obj);
            }

            public override int GetHashCode()
            {
                return (Height + RowIdx * 113 + ColumnIdx * 1023).GetHashCode();
            }

            public bool Equals(Cell other)
            {
                return (Height == other.Height) && (RowIdx == other.RowIdx) && (ColumnIdx == other.ColumnIdx);
            }

            public int CompareTo(Cell other)
            {
                var heightCmp = Height.CompareTo(other.Height);
                if (heightCmp != 0)
                {
                    return heightCmp;
                }

                var rowCmp = RowIdx.CompareTo(other.RowIdx);
                if (rowCmp != 0)
                {
                    return rowCmp;
                }

                return ColumnIdx.CompareTo(other.ColumnIdx);
            }
        }


        public int TrapRainWater(int[][] heightMap)
        {
            int rowsCount = heightMap.Length;
            if (rowsCount == 0)
            {
                return 0;
            }
            int columnsCount = heightMap[0].Length;

            bool[,] visited = new bool[rowsCount, columnsCount];
            SortedSet<Cell> set = new SortedSet<Cell>();

            for (int i = 0; i < rowsCount; i++)
            {
                set.Add(new Cell(heightMap[i][0], i, 0));
                set.Add(new Cell(heightMap[i][columnsCount - 1], i, columnsCount - 1));
                visited[i, 0] = true;
                visited[i, columnsCount - 1] = true;
            }

            for (int j = 1; j < columnsCount - 1; j++)
            {
                set.Add(new Cell(heightMap[0][j], 0, j));
                set.Add(new Cell(heightMap[rowsCount - 1][j], rowsCount - 1, j));
                visited[0, j] = true;
                visited[rowsCount - 1, j] = true;
            }

            (int, int)[] directions = { (-1, 0), (1, 0), (0, -1), (0, 1) };
            int currentMaxHeight = 0;
            int res = 0;
            while (set.Count > 0)
            {
                var cell = set.First();
                set.Remove(cell);

                currentMaxHeight = Math.Max(currentMaxHeight, cell.Height);

                foreach (var dir in directions)
                {
                    int nextRowIdx = cell.RowIdx + dir.Item1;
                    int nextColIdx = cell.ColumnIdx + dir.Item2;

                    if (nextRowIdx >= 0 && nextRowIdx < rowsCount && nextColIdx >= 0 && nextColIdx < columnsCount && !visited[nextRowIdx, nextColIdx])
                    {
                        var nextHeight = heightMap[nextRowIdx][nextColIdx];
                        if (currentMaxHeight > nextHeight)
                        {
                            res += currentMaxHeight - nextHeight;
                        }

                        set.Add(new Cell(nextHeight, nextRowIdx, nextColIdx));
                        visited[nextRowIdx, nextColIdx] = true;
                    }
                }
            }

            return res;
        }
    }
}
