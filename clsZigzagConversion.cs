using System.Text;

namespace InterviewPrep
{
    public static class clsZigzagConversion
    {
        public static string Convert(string s, int numRows)
        {

            if (numRows == s.Length || numRows == 1 || numRows < 1 || numRows > s.Length) return s;

            int i = 0;
            int cur_row = 0;
            var sb = new StringBuilder();

            while (cur_row < numRows)
            {
                i = cur_row;
                bool down = true;
                if (i > 0 && i < numRows - 1)
                {
                    while (i < s.Length)
                    {
                        sb.Append(s[i]);

                        if (down)
                            i += (2 + 2 * ((numRows - 1) - (cur_row + 1)));
                        else
                            i += (2 + 2 * (cur_row - 1));
                        down = !down;
                    }
                }
                else
                {
                    while (i < s.Length)
                    {
                        sb.Append(s[i]);
                        i += (2 * numRows - 2);
                    }
                }

                cur_row++;
            }

            return sb.ToString();
        }

    }
}