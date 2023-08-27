using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node1 {
        public int data;
        public Node1 next;
        public Node1(int data)
        {
            this.data = data;
        }
    }
    public class AddElementInLinkedList
    {
        public Node1 head;
        public void Add(int e)
        {
            Node1 temp = new Node1(e);
            if (head == null)
            {
                head = temp;
            }
            else {
                Node1 current = head;
                while (current.next != null) {
                    current = current.next;
                }
                current.next = temp;

            }
        }
        public void Traverse()
        {
            Node1 curr = head;
            if (curr != null)
            {
                while (curr != null)
                {
                    Console.WriteLine(curr.data);
                    curr = curr.next;
                }
            }
        }
    }
}
