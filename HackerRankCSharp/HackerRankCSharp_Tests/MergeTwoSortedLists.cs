using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankCSharp_Tests
{
    public class SinglyLinkedListNode
    {
        public int data { get; set; }
        public SinglyLinkedListNode head { get; set; } 
        public SinglyLinkedListNode next { get; set; } 
    }

    public class MergeTwoSortedLists
    {
        static SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            if (head1 == null)
            {
                return head2;
            }
            if (head2 == null)
            {
                return head1;
            }

            if (head1.data < head2.data)
            {
                head1.next = mergeLists(head1.next, head2);
                return head1;
            }
            else
            {
                head2.next = mergeLists(head1, head2.next);
                return head2;
            }
        }
    }
}
