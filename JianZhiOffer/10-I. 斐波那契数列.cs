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

        //这道题的关键就是当输入的n太大时，就连上限为18,446,744,073,709,551,615的ulong都会溢出。
        //要求返回的是对1,000,000,007取余后的int结果，而int的上限是2,147,483,647 > 1,000,000,007 * 2。
        //因此可以每次计算新项就对1,000,000,007取余，可以保证两项加起来绝不会溢出
        public int Fib(int n)
        {
            //基本情况
            if (n == 0) return 0;
            if (n == 1) return 1;

            //用队列表示，用完的项出队
            Queue<int> q = new Queue<int>();
            q.Enqueue(0);
            q.Enqueue(1);

            for (int i = 0; i < n - 1; i++)
                q.Enqueue((q.Dequeue() + q.Peek()) % 1000000007);
            q.Dequeue();
            return q.Peek();
        }
    }
}