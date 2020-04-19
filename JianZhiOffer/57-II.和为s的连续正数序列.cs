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

        //记一组解的首个数字为a，共有连续n项
        //用等差数列求和公式可以算得：
        //a = (2t-n^2+n)/2n
        //因为a为整数，逐个测试能使a为整数的n即可得到一组解
        public int[][] FindContinuousSequence(int target)
        {
            if (target <= 2) return new int[0][];
            List<int[]> ret = new List<int[]>();
            List<int> sol = new List<int>();
            for (int n = target - 1; n >= 2; n--)
            {
                int a = (int)(target * 2 - Math.Pow(n, 2) + n);
                if (a % (n * 2) != 0 || a <= 0)
                    continue;
                else
                {
                    a = a / (n * 2);
                    for (int i = 0; i < n; i++)
                        sol.Add(a + i);
                    ret.Add(sol.ToArray());
                    sol.Clear();
                }
            }
            return ret.ToArray();
        }
    }
}