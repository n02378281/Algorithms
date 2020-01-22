public class BSTPreOrderTraversal{
public static void PreOrder(Node root){
Stack<Node> stk= new Stack<Node>();
  while(true){
    while(root!=null){
	  ArrList.Add(root.value);
	  stk.Push(root);
	  root=root.left;
	}
	
	if(stack.count<=0)
	    break;
		else{
		  root=stack.Pop();
		  root= root.Right();
		}
  }
}

}
