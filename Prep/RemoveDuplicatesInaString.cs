using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    public class RemoveDuplicatesInaString
    {

        public static String removeDup(String s)
        {
            if (s == null) return null;
            int l = s.Length;
            //if length is less than 2 return string
            if (l < 2) return s;
            char[] arr = s.ToCharArray();

            for (int i = 0; i < l; i++)
            {
                int j = i + 1; //index to check with ith index
                int t = i + 1; //index of first repetative char.

                while (j < l)
                {
                    if (arr[j] == arr[i])
                    {
                        j++;

                    }
                    else
                    {
                        arr[t] = arr[j];
                        t++;
                        j++;
                    }

                }
                l = t;
            }

            return new String(arr, 0, l);
        }
    }
}
