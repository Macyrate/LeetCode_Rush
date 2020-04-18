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
    }

    public class CQueue
    {
        protected Stack<int> stackHelp;     //辅助栈
        protected Stack<int> stackStorage;  //存储栈
        public CQueue()
        {
            stackHelp = new Stack<int>();
            stackStorage = new Stack<int>();
        }

        public void AppendTail(int value)
        {
            stackStorage.Push(value);       //入队，直接压入存储栈即可
        }

        public int DeleteHead()
        {
            if (!stackStorage.Any()) return -1;     //存储栈没东西时出队，返回-1

            while (stackStorage.Count > 1)          //把存储栈倒入辅助栈。注意这里不应用for循环，因为每次循环都会重新计算Count，导致Count越来越小
                stackHelp.Push(stackStorage.Pop());

            int result = stackStorage.Pop();        //留一个栈底元素，即最早入栈的，作为队首出队

            while (stackHelp.Count > 0)             //再把辅助栈倒回存储栈。这里也一样，不应用for循环
                stackStorage.Push(stackHelp.Pop());

            return result;
        }
    }
}