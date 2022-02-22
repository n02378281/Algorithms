using InterviewPrep;
using System.Collections.Generic;

public class BSTPreOrderTraversal
{
    public static void PreOrder(Node root)
    {
        Stack<Node> stk = new Stack<Node>();
        List<int> list = new List<int>();
        while (true)
        {
            while (root != null)
            {
                list.Add(root.data);
                stk.Push(root);
                root = root.left;
            }

            if (stk.Count <= 0)
                break;
            else
            {
                root = stk.Pop();
                root = root.right;
            }
        }
    }

}
