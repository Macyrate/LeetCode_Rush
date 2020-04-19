/*
 * @lc app=leetcode.cn id=7 lang=csharp
 *
 * [7] 整数反转
 */

// @lc code=start
public class Solution
{
    public int Reverse(int x)
    {   
        //考虑反转之后溢出，用long存储
        long rev = 0;
        while (x != 0)
        {
            int tmp = x % 10;
            rev = rev * 10 + tmp;
            x = x / 10;         //C#斜杠除向下取整
        }

        //判断转换结果是否溢出
        if (rev > 2147483647 || rev < -2147483648)
        {
            return 0;
        }

        //返回时转换回int
        return (int)rev;
    }
}
// @lc code=end

