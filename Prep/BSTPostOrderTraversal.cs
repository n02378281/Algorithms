public class BSTPostOrderTraversal{
private void postorder(Node root) {
  if (root == null) { return;}  
  stack.push(root);
  while (!stack.isEmpty()) {
    Node temp = stack.peek();

    boolean finishedSubtrees = (temp.right == root || temp.left == root);
    boolean isLeaf = (temp.left == null && temp.right == null);
    if (finishedSubtrees || isLeaf) {
      stack.pop();
      Arr.Add(temp.value);
      root = temp;
    }
    else {
      if (temp.right != null) {
        stack.push(temp.right);
      }
      if (temp.left != null) {
        stack.push(temp.left);
      }    }  }}
}
