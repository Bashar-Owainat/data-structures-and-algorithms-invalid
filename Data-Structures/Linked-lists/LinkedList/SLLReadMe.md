# Singly Linked List
## Summary
I did an implementation for SLL with two classes that are called SLL and Node

## Challenge 5
In the SLL class there are 3 methods:
1-Insert
2-Includes
3-ToStringMethod


In the Node class there are two properties:
1-value
2-next

and I created these test methods to test some functionality:

1-EmptyInstantiation
2-Insert
3-PointAtHead
4-InsertMultipleNodes
5-FindValue
6-ValueNotFound
7-RetunValues

## Approach & Efficiency

Insert = O(1)

Includes = O(n)

ToStringMethod = O(n)


## API
Insert: it adds a given value to the head and it works with empty lists.

Includes: It checks if a given value is included in the SLL.

ToStringMethid: it prints the SLL in the following format:

[1] -> [2] -> [3] -> NULL



## Challenge 6

## Methods
4- Append


### tests for Challenge 6
8-AppendOneNode
9-AppendMultipleNodes


### Approach & Efficiency for Challenge 6
Append = O(n)


### API for Challenge 6

Append: it adds a node at the end of the linked lists


## challenge 7

### Methods for challenge 7

KthFromEnd


### tests for challenge 7

KOutOfRange : it tests what will happen if the user inputs number that is greater than the linked list’s length.(it will throw IndexOutOfRange)

SameNumbers: it tests what will happen if “K” (the user’s input) has the same length as the linked lists.

NegativeNumbers: it tests if K is a negative number.

OneNumber: it tests what will happen if linked list has one number only.

NumberInMiddle: it tests the behavior of the method when K is in the middle of the linked list. 

### Approach & Efficiency for Challenge 7

KthFromEnd = O(n)


### API for Challenge 7

KthFromEnd: a method that takes an integer as a parameter and uses this number to start counting from the end of the linked list to give you the value in that index.

Note:
-	It starts counting from 1 not zero


