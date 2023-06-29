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
	public static void topView(Node root) {
        // Level Order Traversal
        Queue<Node> levelQueue = new LinkedList<Node>();
        ArrayList<Node> levelOrder = new ArrayList<Node>();
        levelQueue.add(root);
        
        Node curr = root;
        while(!levelQueue.isEmpty()) {
            curr = levelQueue.remove();
            if (curr.left != null) {
                levelQueue.add(curr.left);
            }
            if (curr.right != null) {
                levelQueue.add(curr.right);
            }
            levelOrder.add(curr);
        }
        
        // Print levelOrder for debugging purpose
        // for (Node item : levelOrder) {
        //     System.out.print(item.data + " ");
        // }
        
        
        // Vertical Order Traversal
        TreeMap<Integer, ArrayList<Node>> distanceMap = new TreeMap<Integer, ArrayList<Node>>();
        getVerticalOrder(root, 0, distanceMap);
        
        // Print distanceMap for debbuging purpose
        // System.out.println("distanceMap");
        // for(Map.Entry<Integer, ArrayList<Node>> entry : distanceMap.entrySet()) {
        //     Integer key = entry.getKey();
        //     ArrayList<Node> value = entry.getValue();

        //     System.out.print(key + " => ["); // + value);
        //     for (Node item : value) {
        //         System.out.print(item.data + " ");
        //     }
        //     System.out.println("]");
        // }
      
        // Create a map of levelOrder
        HashMap<Integer, Integer> levelNodeOrderMap = new HashMap<Integer, Integer>();
        for (int i = 0; i < levelOrder.size(); i++){
            int index = i;
            Node node = levelOrder.get(index);
            levelNodeOrderMap.put(node.data, index);
        }
        
        // System.out.println("levelNodeOrderMap");
        // System.out.println(levelNodeOrderMap);
        
        // System.out.println("Final result");        
        // Combine level order traversal and vertical order traversal
        // consider each distance in vertical order traversal, choose the node with smallest traversal order index
        for(Map.Entry<Integer, ArrayList<Node>> entry : distanceMap.entrySet()) {
            Integer distance = entry.getKey();
            ArrayList<Node> sameDistanceNodes = entry.getValue();
            
            // Choose node with smallest order index
            int smallestIndex = Integer.MAX_VALUE;
            Node highestNode = null;
            
            // System.out.println("======================");
            for (Node currentNode : sameDistanceNodes) {
                if (levelNodeOrderMap.get(currentNode.data) < smallestIndex) {
                    // System.out.println("currentNode.data " + currentNode.data);
                    // System.out.println("levelNodeOrderMap.get(currentNode.data) " + levelNodeOrderMap.get(currentNode.data));
                    // System.out.println("smallestIndex " + smallestIndex);
                    highestNode = currentNode;
                    smallestIndex = levelNodeOrderMap.get(currentNode.data);
                    // System.out.println("highestNode.data " + highestNode.data);
                }
            }
            
            System.out.print(highestNode.data + " ");       
            // System.out.println("Distance: " + distance + ", node: " + highestNode.data); 
        }
        
    }
    
    private static void getVerticalOrder(Node curr, int horizontalDistance, TreeMap<Integer, ArrayList<Node>> distanceMap ) {
        
        // base case
        if (curr == null) {
            return;
        }
        
        // get the nodes (ArrayList<Integer>) which have key (Integer) == horizontalDistance
        // If the value of that key is not exist, add a new key: value pair to the distance map
        ArrayList<Node> sameDistanceNodes;
        if (distanceMap.containsKey(horizontalDistance)) {
            sameDistanceNodes = distanceMap.get(horizontalDistance);
            sameDistanceNodes.add(curr);
        } else {
            sameDistanceNodes = new ArrayList<Node>();
            sameDistanceNodes.add(curr);
            distanceMap.put(horizontalDistance, sameDistanceNodes);
        }
        
        // Recursively getVerticalOrder of the left child  
        getVerticalOrder(curr.left, horizontalDistance-1, distanceMap);
        
        // Recursively getVerticalOrder of the right child
        getVerticalOrder(curr.right, horizontalDistance+1, distanceMap);        
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
        topView(root);
    }	
}