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

    public static void inOrder(Node root) {
        // // Recursive approach
        // if (root == null) {
        //     return;
        // }
        // // Left
        // inOrder(root.left);
        // // Root
        // System.out.print(root.data + " ");
        // // Right
        // inOrder(root.right);
        
        // Iterative approach
        if (root == null) {
            return;
        }
        
        Node curr = root;
        
        Stack<Node> nodeStack = new Stack<Node>();
        
        while (true) {
            // Visit left, visit current, then visit right
            
            // If current node is not null
            if (curr != null) {
                // Add current node to parent stack for later visit
                nodeStack.add(curr);
                // Move to left child
                curr = curr.left;
            } else {
                // If the parent stack is empty, the whole tree has been traversed
                if (nodeStack.empty()) {
                    break;
                }
                
                // get parent node
                curr = nodeStack.pop();
                
                // visit parent node
                System.out.print(curr.data + " ");
                
                // Move to right child
                curr = curr.right;
                
            }
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
        inOrder(root);
    }	
}