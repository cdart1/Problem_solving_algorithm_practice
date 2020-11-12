using System;
using System.Collections.Generic;

namespace ReverseLinkedList
{
    // Reverse a singly linked list.
    class Program
    {
        static void Main(string[] args)
        {
            Node head = new Node(1);
            head.next = new Node(2);
            head.next.next = new Node(3);
            head.next.next.next = new Node(4);

            Node node = ReverseLinkedListProblem.ReverseLinkedList2(head);
            int firstNode = node.val;
            int secondNode = node.next.val;
            int thirdNode = node.next.next.val;
            int fourthNode = node.next.next.next.val;

            Console.WriteLine("{0} {1} {2} {3}", firstNode, secondNode, thirdNode, fourthNode);
        }
    }
}
