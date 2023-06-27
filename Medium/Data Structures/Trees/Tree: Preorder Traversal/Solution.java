import java.util.*;
import java.io.*;

class Node {
    Node left;
    Node right;
    int data;
    
    Node(int data) {
        this.data = data;
        left = null;
        right = null;
    }
}

class Solution {

/* you only have to complete the function given below.  
Node is defined as  

class Node {
    int data;
    Node left;
    Node right;
}

*/

    public static void preOrder(Node root) {
        // Recursive approach
        if (root == null) {
            return;
        }
        
        System.out.print(root.data + " ");
        preOrder(root.left);
        preOrder(root.right);
        
        // // Iterative approach
        // Stack<Node> traversalStack = new Stack<Node>();
        // traversalStack.add(root);
        
        // while (!traversalStack.empty()) {           
        //     Node currNode = traversalStack.pop();
        //     System.out.print(currNode.data + " ");
        //     if (currNode.right != null) {
        //         traversalStack.push(currNode.right);
        //     }
            
        //     if (currNode.left != null){
        //         traversalStack.push(currNode.left);
        //     }

        // }
    }

	public static Node insert(Node root, int data) {
        if(root == null) {
            return new Node(data);
        } else {
            Node cur;
            if(data <= root.data) {
                cur = insert(root.left, data);
                root.left = cur;
            } else {
                cur = insert(root.right, data);
                root.right = cur;
            }
            return root;
        }
    }

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int t = scan.nextInt();
        Node root = null;
        while(t-- > 0) {
            int data = scan.nextInt();
            root = insert(root, data);
        }
        scan.close();
        preOrder(root);
    }	
}