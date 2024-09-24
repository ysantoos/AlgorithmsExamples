// See https://aka.ms/new-console-template for more information


using SingleLinkedList;

var singleLinkedList = new SingleLinkedList.SingleLinkedList();
var RemoveDups = new RemoveDuplicates();

// EXAMPLE 1 : Append and Delete node
Console.WriteLine("***********************");
Console.WriteLine("Append and Delete node");
singleLinkedList.print();
singleLinkedList.append(value: 1);
singleLinkedList.append(value: 2);
singleLinkedList.append(value: 3);
singleLinkedList.print();
singleLinkedList.append(value: 4);
singleLinkedList.append(value: 5);
singleLinkedList.print();
singleLinkedList.deleteNode(1);
singleLinkedList.print();

singleLinkedList.deleteNode(value: 3);
singleLinkedList.print();


// EXAMPLE 2 : Remove duplicates values in single linked list
Console.WriteLine("***********************");
Console.WriteLine("Remove duplicates values in single linked list");


Node head = new Node(_value: 1);
head.next = new Node(_value: 2);
head.next.next = new Node(_value: 2);
head.next.next.next = new Node(_value: 3);
head.next.next.next.next = new Node(_value: 4);
head.next.next.next.next.next = new Node(_value: 1);
singleLinkedList.print(head);
RemoveDups.RemoveDup(head);
Console.WriteLine("***********************");
singleLinkedList.print(head);




