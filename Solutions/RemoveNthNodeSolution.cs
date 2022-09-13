using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeSolutions
{
    public class RemoveNthNodeSolution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var dummy = new ListNode(0, head);
            var left = dummy;
            var right = head;

            while(n > 0 && right is not null)
            {
                right = right.next;
                n--;
            }

            while(right is not null)
            {
                left=left.next;
                right = right.next;
            }
            left.next = left.next.next;

            return dummy.next;
        }
    }
}
