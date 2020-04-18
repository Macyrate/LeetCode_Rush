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

        public string ReplaceSpace(string s)
        {
            //Replace有两个重载，一个换字符一个换子串
            return s?.Replace(" ", "%20");
        }
    }
}