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

        public bool FindNumberIn2DArray(int[][] matrix, int target)
        {
            int row = matrix.Length;
            if (row == 0) return false;      //需要判断矩阵是否为空
            int column = matrix[0].Length;

            //当前坐标。从右上角开始查找，既可以往大了找也可以往小了找
            int x = 0, y = row - 1;

            while (x >= 0 && x < column && y >= 0 && y < row)
            {
                if (matrix[y][x] == target)     //刚好找到
                    return true;
                if (matrix[y][x] < target)      //不够大，往下找更大的
                    x++;
                else                            //太大了，往左找更小的
                    y--;
            }
            return false;
        }
    }
}