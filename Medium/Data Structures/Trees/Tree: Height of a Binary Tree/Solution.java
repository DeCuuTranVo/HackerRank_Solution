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

	/*
    class Node 
    	int data;
    	Node left;
    	Node right;
	*/
	public static int height(Node root) {
        // https://www.youtube.com/watch?v=qeedp3xsg_8&ab_channel=XavierElon
        
      	// // Iterative approach
        // if (root == null) {
        //     return 0;
        // }
          
        // // int currHeight = 0;
        // int maxHeight = 0;
        
        // Queue<Node> nodeQueue = new LinkedList<Node>();
        // Queue<Integer> heightQueue = new LinkedList<Integer>();
        
        // nodeQueue.add(root);
        // heightQueue.add(0);
        
        // while(!nodeQueue.isEmpty()) {
        //     Node currNode = nodeQueue.remove();
        //     Integer currHeight = heightQueue.remove();
            
        //     if (currNode.left != null) {
        //         nodeQueue.add(currNode.left);
        //         heightQueue.add(currHeight+1);
        //     }
        //     if (currNode.right != null) {
        //         nodeQueue.add(currNode.right);
        //         heightQueue.add(currHeight+1);
        //     }
            
        //     if (maxHeight < currHeight) {
        //         maxHeight = currHeight;
        //     }            
            
        //     // // String display = "\t";
        //     // for (int i = 0; i < currHeight; i++) {
        //     //     System.out.print("\t");
        //     // }
        //     // System.out.println(currNode.data);
        // }
    
        // return maxHeight;
        
        // Recursive approach
        Node curr = root;
        if (curr == null) {
            return -1;
        }
        int leftHeight = height(curr.left) + 1;
        int rightHeight = height(curr.right) + 1;
        if (leftHeight >= rightHeight) {
            return leftHeight;
        } else {
            return rightHeight;
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
        int height = height(root);
        System.out.println(height);
    }	
}