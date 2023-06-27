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

    public static void postOrder(Node root) {
        // // Recursive approach
        // if (root == null) {
        //     return;
        // }
        
        // postOrder(root.left);
        // postOrder(root.right);
        // System.out.print(root.data + " ");
        
        // Iterative approach
        Stack<Node> stackOne = new Stack<Node>();
        Stack<Node> stackTwo = new Stack<Node>();
        
        stackOne.add(root);
        
        while(!stackOne.empty()) {
            Node currNode = stackOne.pop();
            stackTwo.add(currNode);
            
            if (currNode.left != null) {
                stackOne.add(currNode.left);
            }
            
            if (currNode.right != null) {
                stackOne.add(currNode.right);
            }
        }
        
        while(!stackTwo.empty()) {
            Node currNode = stackTwo.pop();
            System.out.print(currNode.data + " ");
        }
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
        postOrder(root);
    }	
}