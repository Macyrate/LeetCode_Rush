public class Solution {
    public int SingleNumber(int[] nums) {
        if(nums.Length == 1)
            return nums[0];
        var hashset = new HashSet<int>();
        foreach(var n in nums)
            _ = hashset.Contains(n)?hashset.Remove(n):hashset.Add(n);
        return hashset.ToList()[0];
    }
}

//走火入魔一行流
public int SingleNumber(int[] nums) => (nums.Length == 0?nums[0]:(from n in nums group n by n into ns where ns.Count() == 1 select ns.First()).First());