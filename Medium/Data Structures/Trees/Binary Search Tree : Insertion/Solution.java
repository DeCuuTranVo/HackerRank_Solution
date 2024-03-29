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
   
  	public static void preOrder( Node root ) {
      
    	if( root == null)
        	return;
      
        System.out.print(root.data + " ");
        preOrder(root.left);
        preOrder(root.right);
     
    }

 /* Node is defined as :
 class Node 
    int data;
    Node left;
    Node right;
    
    */

	public static Node insert(Node root,int data) {
        // traverse(root, 0);
        // return root;
        // recursive approach
        if (root == null) {
            return new Node(data);
        }
        
        if (data < root.data ){
            root.left = insert(root.left, data);
        } else if (data > root.data) {
            root.right = insert(root.right, data);
        } else{
            return root;
        }
        
        return root;
        
        
        // // iterative approach	
        // if (root == null) {
        //     return new Node(data);
        // }
        // Node curr = root;
        // while (true) {
        //     if (data < curr.data) {
        //         if (curr.left != null) {
        //             curr = curr.left;
        //         } else {
        //             curr.left = new Node(data);
        //             return root;
        //         }
        //     } else if (data > curr.data) {
        //         if (curr.right != null) {
        //             curr = curr.right;
        //         } else {
        //             curr.right = new Node(data);   
        //             return root;
        //         }
        //     } else { //curr == curr.data
        //         return root;
        //     }
        // }
    }
    
    public static void traverse(Node root, int depth) {
        if (root == null) {
            return;
        }
        
        System.out.println("line 78");
        traverse(root.left, depth+1);
        for (int i = 0; i < depth; i++) {
            System.out.print("/t");
        }
        System.out.println(root.data);
        traverse(root.right, depth+1);
        
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