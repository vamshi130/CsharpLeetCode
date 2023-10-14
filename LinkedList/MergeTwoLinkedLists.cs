using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
      public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int val)
        {
            this.val = val;
         }
  }
    public class ListNode1
    {
        public int val;
        public ListNode1 next;
        public ListNode1(int val)
        {
            this.val = val;
        }
    }
    public class MergeTwoLinkedLists
    {
        ListNode head1;
        ListNode head2;
        ListNode dummyHead = new ListNode(0);
        public void AddList(int e)
        {
            ListNode node1 = new ListNode(e);
            if(head1 == null)
            {
                head1 = node1;
            }
            else
            {
                ListNode curr=head1;
                while(curr.next != null)
                {
                    curr = curr.next;
                }
                curr.next = node1;
            }
           
        }
        public void AddList2(int e)
        {
            ListNode node2 = new ListNode(e);
            if (head2 == null)
            {
                head2 = node2;
            }
            else
            {
                ListNode curr = head2;
                while (curr.next != null)
                {
                    curr = curr.next;
                }
                curr.next = node2;
            }

        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            list1 = head1;
            list2=head2;
            ListNode dummyHead = new ListNode(0);
            // Create a dummy node as the starting point
            ListNode curr = dummyHead;
            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    curr.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    curr.next = list2;
                    list2 = list2.next;
                }
                curr =curr.next;
            }
            if(list1 != null)
            {
                curr.next=list1;
            }
            if (list2 != null)
            {
                curr.next=list2;
            }
            dummyHead = dummyHead.next;

            Console.WriteLine("hiiiiiiiii");
            //while (dummyHead != null)
            //{
            //    Console.WriteLine(dummyHead.val);
            //    dummyHead = dummyHead.next;
            //}
            RemoveNthFromEnd(dummyHead, 1);
            return curr;
        }
        public ListNode RemoveNthFromEnd(ListNode dummyHead,int n)
        {
            int count = 0;
            ListNode curr = dummyHead;
            while (curr != null)
            {
                curr = curr.next;
                count++;
            }
            if(n==count)
            {
                return dummyHead.next;
            }
            int del = count - n;
            ListNode dum = dummyHead;
            int i = 0;
            while (i < del-1)
            {
                dum = dum.next;
                i++;
            }
            dum.next = dum.next.next;
            while (dummyHead != null)
            {
                Console.WriteLine(dummyHead.val);
                dummyHead = dummyHead.next;
            }
            return curr;
        }
    }
}
//1,2,3,4,5,6,7,8,9