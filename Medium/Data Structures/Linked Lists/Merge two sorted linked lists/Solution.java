import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    static class SinglyLinkedListNode {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData) {
            this.data = nodeData;
            this.next = null;
        }
    }

    static class SinglyLinkedList {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList() {
            this.head = null;
            this.tail = null;
        }

        public void insertNode(int nodeData) {
            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            if (this.head == null) {
                this.head = node;
            } else {
                this.tail.next = node;
            }

            this.tail = node;
        }
    }

    public static void printSinglyLinkedList(SinglyLinkedListNode node, String sep, BufferedWriter bufferedWriter) throws IOException {
        while (node != null) {
            bufferedWriter.write(String.valueOf(node.data));

            node = node.next;

            if (node != null) {
                bufferedWriter.write(sep);
            }
        }
    }

    // Complete the mergeLists function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
     
    // Method 1: Create a new linkedlist
    /*
    static SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2) {
        if (head1 == null) {
            return head2;
        }
        
        if (head2 == null) {
            return head1;
        }
        
        
        SinglyLinkedList newLList = new SinglyLinkedList();
        SinglyLinkedListNode current1 = head1;
        SinglyLinkedListNode current2 = head2;
        
        while ((current1 != null) && (current2 != null)) {
          // (current1 != null) && (current2 != null)   
            if (current1.data <= current2.data) {
                // SinglyLinkedListNode newNode = new SinglyLinkedListNode(current1.data);
                newLList.insertNode(current1.data);
                current1 = current1.next;
            } else {
                // SinglyLinkedListNode newNode = new SinglyLinkedListNode(current2.data);
                newLList.insertNode(current2.data);
                current2 = current2.next;
            }
        }
        
        if (current1 == null) {
            while (current2 != null) {
                newLList.insertNode(current2.data);
                current2 = current2.next;
            }
        } else { //current2 == null
            while (current1 != null) {
                newLList.insertNode(current1.data);
                current1 = current1.next;
            }
        }
        
        return newLList.head;       
    }
    */
    
    // method 2, inline merging of 2 linkedlists
    static SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2) {
        if (head1 == null) {
            return head2;
        }
        
        if (head2 == null) {
            return head1;
        }
        
        // 0 is an arbitrary number
        SinglyLinkedListNode newHead = new SinglyLinkedListNode(0);
        SinglyLinkedListNode newCurr = newHead;
        
        SinglyLinkedListNode curr1 = head1;
        SinglyLinkedListNode curr2 = head2;
        
        while ((curr1 != null) && (curr2 != null)) {
            if (curr1.data <= curr2.data) {
                newCurr.next = curr1;
                curr1 = curr1.next;
            } else {
                newCurr.next = curr2;
                curr2 = curr2.next; 
            }
            
            newCurr = newCurr.next;
        }
        
        if (curr1 != null) {
            newCurr.next = curr1;
        }
        
        if (curr2 != null) {
            newCurr.next = curr2;
        }
        
        newHead = newHead.next;
        return newHead;
        
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int tests = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int testsItr = 0; testsItr < tests; testsItr++) {
            SinglyLinkedList llist1 = new SinglyLinkedList();

            int llist1Count = scanner.nextInt();
            scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

            for (int i = 0; i < llist1Count; i++) {
                int llist1Item = scanner.nextInt();
                scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

                llist1.insertNode(llist1Item);
            }
          
          	SinglyLinkedList llist2 = new SinglyLinkedList();

            int llist2Count = scanner.nextInt();
            scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

            for (int i = 0; i < llist2Count; i++) {
                int llist2Item = scanner.nextInt();
                scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

                llist2.insertNode(llist2Item);
            }

            SinglyLinkedListNode llist3 = mergeLists(llist1.head, llist2.head);

            printSinglyLinkedList(llist3, " ", bufferedWriter);
            bufferedWriter.newLine();
        }

        bufferedWriter.close();

        scanner.close();
    }
}
