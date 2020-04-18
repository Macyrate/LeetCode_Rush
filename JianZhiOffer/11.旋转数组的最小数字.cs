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

        //旋转之后数列被划分为两段各自递增的部分，用二分法找出分界点即是最小值
        public int MinArray(int[] numbers)
        {
            int len = numbers.Length;
            int l = 0, r = len - 1;
            while (l < r)
            {
                int cen = (l + r) / 2;
                if (numbers[cen] < numbers[r])          //中间和最右属于同一段递增部分，说明分界点在左边
                    r = cen;
                else if (numbers[cen] > numbers[r])     //中间和最左属于同一段递增部分，说明分界点在右边
                    l = cen + 1;
                else if (numbers[cen] == numbers[r])    //连续相等的情况下，可以缩小范围
                    r--;
            }
            return numbers[r];
        }
    }
}