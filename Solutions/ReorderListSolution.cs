using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeSolutions
{
    public class ReorderListSolution
    {
        public static void ReorderList(ListNode head)
        {
            var slow = head;
            var fast = head.next;

            while (fast is not null && fast.next is not null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            var second = slow.next;
            slow.next = null;
            var prev = slow.next;

            while(second is not null)
            {
                var temp = second.next;
                second.next = prev;
                prev = second;
                second = temp;
            }

            var first = head;
            second = prev;

            while (second is not null)
            {
                var temp1 = first.next;
                var temp2 = second.next;
                first.next = second;
                second.next = temp1;
                first = temp1;
                second = temp2;
            }
        }
    }
}
