﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeSolutions
{
    public class LinkedListCycleSolution
    {
        public static bool HasCycle(ListNode head)
        {
            var slow = head;
            var fast = head;

            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if(slow == fast)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
