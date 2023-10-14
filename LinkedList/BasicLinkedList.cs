using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node{
        public int data;
        public Node next;
     }
    public class BasicLinkedList
    {
        public Node head;
        public BasicLinkedList()
        {
            head = null;
        }
        public void ReverseLinkedList()
        {
            Node prev = null;
            Node curr = head;
            while (curr != null)
            {
                Node node = curr.next;
                curr.next = prev;
                prev = curr;
                curr = node;
            }

            head = prev;
        }
        public void Traverse()
        {
            Node temp = new Node();
            temp = this.head;
            if(temp != null)
            {
                while (temp != null) { 
                     Console.WriteLine(temp.data);  
                    temp = temp.next;
                }
            }
        }
    }
}
