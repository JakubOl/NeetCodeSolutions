namespace NeetCodeSolutions
{
    public class MergeTwoSortedListsSolution
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var dummy = new ListNode();
            var tail = dummy;

            while (list1 != null && list2 != null)
            {
                if(list1.val < list2.val)
                {
                    tail.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    tail.next = list2;
                    list2 = list2.next;
                }
                tail = tail.next;
            }
            if (list1 is not null)
            {
                tail.next = list1;
            }else if (list2 is not null)
            {
                tail.next = list2;
            }

            return dummy.next;
        }
    }

    //public class ListNode
    //{
    //    public int val;
    //    public ListNode next;
    //    public ListNode(int val = 0, ListNode next = null)
    //    {
    //        this.val = val;
    //        this.next = next;
    //    }
    //}
}
