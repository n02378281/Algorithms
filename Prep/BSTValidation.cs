using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    public class BSTValidation
    {
        public bool isValidBST(TreeNode root)
        {
            if (root == null) return true;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode previous = null;
            TreeNode current = root;
            while (current != null || stack.Count != 0)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }
                current = stack.Pop();
                if (previous != null && current.value <= previous.value) return false;
                previous = current;
                current = current.right;
            }
            return true;
        }
    }
}
