/*
 * @lc app=leetcode.cn id=10 lang=csharp
 *
 * [10] 正则表达式匹配
 */

// @lc code=start
public class Solution
{
    public bool IsMatch(string s, string p)
    {
        //没有.和*的时候，s和p相等才匹配
        if (!p.Contains('.') && !p.Contains('*'))
        {
            return s.Equals(p) ? true : false;
        }

        //开始找.和*，进行解析
        int startIndex = 0;
        int charIndex = p.IndexOfAny(new char[] { '.', '*' }, startIndex);
        while (charIndex != -1)
        {
            
            s = s.Substring(charIndex);
        }

        //解析完了还有剩的，说明不匹配
        if (s.Length != 0)
            return false;
    }
}
// @lc code=end

