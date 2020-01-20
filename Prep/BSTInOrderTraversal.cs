using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    public class TreeNode
    {
        public int value;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int data)
        {
            this.value = data;
            left = null;
            right = null;
        }
    }
    //    Given a binary tree, return the inorder traversal of its nodes' values.

    //Example:

    //Input: [1,null,2,3]
    //   1
    //    \
    //     2
    //    /
    //   3

    //Output: [1,3,2]
    //    Follow up: Recursive solution is trivial, could you do it iteratively?
    class BSTInOrderTraversal
    {
        public List<Int32> inorderTraversal(TreeNode root)
        {
            List<Int32> list = new List<Int32>();

            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode cur = root;

            while (cur != null || stack.Count != 0)
            {
                while (cur != null)
                {
                    stack.Push(cur);
                    cur = cur.left;
                }
                cur = stack.Pop();
                list.Add(cur.value);
                cur = cur.right;
            }

            return list;
        }

        public List<Int32> inorderTraversal1(TreeNode root)
        {
            List<Int32> list = new List<Int32>();
            if (root == null) return list;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (root != null || stack.Count != 0)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                list.Add(root.value);
                root = root.right;

            }
            return list;
        }
    }
}
