using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayGround
{
    class Program
    {

        static void Main(string[] args)
        {
            string input = "abaccdeff";
            Console.WriteLine(new Program().FirstUniqChar(input));
            List<char> vs = new List<char>();
        }

        public char FirstUniqChar(string s)
        {
            if (s.Length == 0) return ' ';
            
            //用LINQ按照字符分组，取第一个Count()为1的，即只出现一次的字符
            var ret = from c in s
                      group c by c into cs
                      where cs.Count() == 1
                      select cs.First();
            if (ret.Count() == 0) return ' ';
            return ret.First();
        }
    }
}