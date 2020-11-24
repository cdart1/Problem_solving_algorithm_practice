using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseLinkedList
{

    class ReverseLinkedListProblem
    {
        /// <summary>
        /// This has a runtime of O(n)
        /// Uses iterative approach to manipulate pointers, returning 'prev' which is the new 'head' 
        /// (the end of the Linkedlist) once 'curr' reaches null.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static Node ReverseLinkedList(Node head)
        {
            Node prev = null;
            Node curr = head;
            Node next = null;

            while(curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            return prev;
        }
        
        public static Node ReverseLinkedList2(Node head)
        {
            /// <summary>
            /// This has a runtime of O(n)
            /// Uses a stack frame to hold each stack call for each recursive call to ReverseLinkedList() method, 
            /// once it reaches the base case (the exit condition) we return 'head' at that point in time then return 
            /// to the top of the call stack, returning each held call back to the previous call (where the previous instance was a different input).
            /// </summary>
            /// <param name="head"></param>
            /// <returns>
            /// Reversed order of a LinkedList.
            /// </returns>
            
            // Exit condition or base case
            if (head == null || head.next == null)
            {
                return head;
            }
            Node reversedLinkedHead = ReverseLinkedList2(head.next);
            head.next.next = head;
            head.next = null;
            return reversedLinkedHead;
        }
    }
}
