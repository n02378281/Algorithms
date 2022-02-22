using InterviewPrep;
using System.Collections.Generic;

public class BSTPostOrderTraversal
{
    private void postorder(Node root)
    {
        Stack<Node> stack = new Stack<Node>();

        List<int> list = new List<int>();
        if (root == null) { return; }
        stack.Push(root);
        while (stack.Count > 0)
        {
            Node temp = stack.Peek();

            bool finishedSubtrees = (temp.right == root || temp.left == root);
            bool isLeaf = (temp.left == null && temp.right == null);
            if (finishedSubtrees || isLeaf)
            {
                stack.Pop();
                list.Add(temp.data);
                root = temp;
            }
            else
            {
                if (temp.right != null)
                {
                    stack.Push(temp.right);
                }
                if (temp.left != null)
                {
                    stack.Push(temp.left);
                }
            }
        }
    }
}
