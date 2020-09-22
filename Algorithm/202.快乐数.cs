/*
 * @lc app=leetcode.cn id=202 lang=csharp
 *
 * [202] 快乐数
 */

// @lc code=start
public class Solution {
    public bool IsHappy(int n) {
        if(n <= 0)
            return false;
        int initN = n;

        //为了检测是否误入无限循环，用哈希表记录出现过的计算结果
        var setN = new HashSet<int>();
        setN.Add(initN);

        while(true)
        {
            int newN = 0;

            //计算新的平方和
            while(n != 0)
            {
                newN += (int)Math.Pow(n % 10, 2);
                n /= 10;
            }

            //判断是否满足快乐数条件
            if(newN == 1)
                break;

            //检测该平方和是否曾出现过
            if(setN.Contains(newN))
                return false;
            
            n = newN;
            setN.Add(newN);
        }
        return true;
    }
}
// @lc code=end

