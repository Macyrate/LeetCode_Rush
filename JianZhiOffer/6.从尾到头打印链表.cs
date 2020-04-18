using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayGround
{
    class Program
    {

        static void Main(string[] args)
        {

        }

        public int[] ReversePrint(ListNode head)
        {
            var list = new List<int>();
            while (head != null)    //遍历链表，加入到List里
            {
                list.Add(head.val);
                head = head.next;   //别忘了移动指针，否则会无限循环
            }
            list.Reverse();         //直接反转List，因为用Stack也要遍历加入List才能转为Array，时间上没啥区别
            return list.ToArray();
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}