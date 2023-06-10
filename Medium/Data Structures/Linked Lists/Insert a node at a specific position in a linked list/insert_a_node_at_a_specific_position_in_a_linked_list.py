#!/bin/python3

import math
import os
import random
import re
import sys

class SinglyLinkedListNode:
    def __init__(self, node_data):
        self.data = node_data
        self.next = None

class SinglyLinkedList:
    def __init__(self):
        self.head = None
        self.tail = None

    def insert_node(self, node_data):
        node = SinglyLinkedListNode(node_data)

        if not self.head:
            self.head = node
        else:
            self.tail.next = node


        self.tail = node

def print_singly_linked_list(node, sep, fptr):
    while node:
        fptr.write(str(node.data))

        node = node.next

        if node:
            fptr.write(sep)

#
# Complete the 'insertNodeAtPosition' function below.
#
# The function is expected to return an INTEGER_SINGLY_LINKED_LIST.
# The function accepts following parameters:
#  1. INTEGER_SINGLY_LINKED_LIST llist
#  2. INTEGER data
#  3. INTEGER position
#

#
# For your reference:
#
# SinglyLinkedListNode:
#     int data
#     SinglyLinkedListNode next
#
#

def insertNodeAtPosition(llist, data, position):
    # Write your code here
    if llist == None:
        new_node = SinglyLinkedListNode(data)
        llist = new_node
        return llist
    else:
        new_node = SinglyLinkedListNode(data)
        head = llist
        current = head
        llist_length = 0
        # find length of linked list
        tail = None
        while (current != None):
            tail = current;
            llist_length += 1
            current = current.next      
        
        # case 1: position == 0
        if position == 0:
            print("case 1")
            new_node.next = head
            head = new_node
        # case 2: position == llist_length
        elif position == llist_length:
            print("case 2")
            tail.next = new_node
        # case 3: position in between 
        else:
            print("case 3")
            pointer = head
            pos_counter = 0
            while (pos_counter < position - 1):
                pointer = pointer.next
                pos_counter+=1
                
            prev_node = pointer
            pos_node = prev_node.next
            prev_node.next = new_node
            new_node.next = pos_node
        
        return head
        

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    llist_count = int(input())

    llist = SinglyLinkedList()

    for _ in range(llist_count):
        llist_item = int(input())
        llist.insert_node(llist_item)

    data = int(input())

    position = int(input())

    llist_head = insertNodeAtPosition(llist.head, data, position)

    print_singly_linked_list(llist_head, ' ', fptr)
    fptr.write('\n')

    fptr.close()
