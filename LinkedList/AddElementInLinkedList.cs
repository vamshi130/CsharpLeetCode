using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                //adding the node at last element
                Node1 current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = temp;

            }
            
        }
        public void AddFirst(int e)
        {
            Node1 temp=new Node1(e);
            if (head == null)
            {
                head = temp;
            }
            else
            {
                temp.next = head;
                head = temp;
            }
        }
        public void AddAtIndex(int index, int e)
        {
            Node1 temp = new Node1(e);
            if(head == null)
            {
                head = temp;
            }
            else
            {
                Node1 current = head;
                int i = 0;
                while (i < index-1)
                {
                    current=current.next;
                    i++;
                }
                temp.next = current.next;
                current.next=temp;
            }
        }
        public void RemoveLastIndex()
        {
            Node1 temp = head;
            if(head == null)
            {
                head = null;
                Console.WriteLine("Nothing to delete");
            }
            else if(head.next == null)
            {
                head = null;
            }
            else
            {
                while (temp.next.next != null)
                {
                    temp= temp.next;
                }
                temp.next = null;
            }
        }
        public void RemoveFirstElement()
        {
            Node1 temp = head;
            if(head == null)
            {
                Console.WriteLine("nothing to delete");
            }
            else
            {
                head=temp.next;
                temp.next = null;
            }
        }
        public void FindIndex(int element)
        {
            Node1 temp = head;
            if(head == null)
            {
                Console.WriteLine("Element doesn't exist");
            }
            else
            {
                int count = 0;
                while(temp.next != null)
                {
                    if(temp.data != element)
                    {
                        count++;
                        temp=temp.next;
                    }
                    if (temp.data == element)
                    {
                        break;
                    }
                }
                Console.WriteLine(count+1 + "  " + " Count ");
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
