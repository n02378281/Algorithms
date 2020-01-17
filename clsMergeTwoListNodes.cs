using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public static class clsMergeTwoListNodes
    {
        public static ListNode MergeTwoListsRecurse(ListNode L1, ListNode L2)
        {
            if (L1 == null)
                return L2;
            if (L2 == null)
                return L1;

            if (L1.val < L2.val)
            {
                L1.next = MergeTwoListsRecurse(L1.next, L2);
                return L1;
            }
            else
            {
                L2.next = MergeTwoListsRecurse(L1, L2.next);
                return L2;
            }

        }

    }
}
