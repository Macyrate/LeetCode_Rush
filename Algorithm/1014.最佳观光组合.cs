/*
 * @lc app=leetcode.cn id=1014 lang=csharp
 *
 * [1014] 最佳观光组合
 */

// @lc code=start
using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int MaxScoreSightseeingPair(int[] A)
    {
        int start = 0, end = A.Length - 1, max = 0;
        while (start < end)
        {
            int score = A[start] + A[end] + start - end;
            max = Math.Max(score, max);
            if (A[start] == A[end])
            {
                max = Math.Max(max,
                Math.Max(
                MaxScoreSightseeingPair(A[start..end]),
                MaxScoreSightseeingPair(A[(start + 1)..(end + 1)])
                ));
                return max;
            }
            else
            {
                _ = A[start] < A[end] ? start++ : end--;
            }
        }
        return max;
    }
}
// @lc code=end

