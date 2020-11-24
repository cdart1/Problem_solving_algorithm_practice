using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseLinkedList
{
    public class Node
    {
        public Node next { get; set; }
        public int val { get; set; }

        public Node(int val)
        {
            this.val = val;
            this.next = null;
        }
       
    }

    public class LinkedList
    {
        public Node head { get; set; }
    }

}
