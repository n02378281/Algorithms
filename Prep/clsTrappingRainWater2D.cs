using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    class clsTrappingRainWater2D
    {
        public int TrapRainWater(int[][] heightMap)
        {

            int[] Top = new int[6];
            int[] Bottom = new int[6];
            int[] Middle = new int[6];

            for (int i = 0; i < 6; i++)
            {
                Top[i] = heightMap[0][i];
                Bottom[i] = heightMap[2][i];

            }
            for (int i = 0; i < 6; i++)
            {
                Middle[i] = Math.Max(0, (Math.Min(Top[i], Bottom[i]) - heightMap[1][i]));
            }

            int water = 0;
            for (int i = 0; i < Middle.Length; i++)
            {
                water += Math.Min(Math.Min(Middle[i], Top[i]), Bottom[i]);
            }

            return water;
        }
    }
}
