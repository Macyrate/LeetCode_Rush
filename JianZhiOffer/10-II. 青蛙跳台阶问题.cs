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

        //由于到达(n-1)阶的所有路径再跳1步就能到n阶，到达(n-2)阶的所有路径再跳2步就能到n阶
        //有NumWays(n) = NumWays(n-1) + NumWays(n-2)，就是个斐波拉契数列
        public int NumWays(int n)
        {
            if (n <= 1) return 1;

            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(1);

            for (int i = 0; i < n - 1; i++)
                if (i <= 12)
                    q.Enqueue(q.Dequeue() + q.Peek());
                else
                    q.Enqueue((q.Dequeue() + q.Peek()) % 1000000007);
            q.Dequeue();
            return q.Peek();
        }
    }
}