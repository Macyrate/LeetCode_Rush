using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayGround
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] input = { 3, 1, 2, 3 };
            Console.WriteLine(new Program().FindRepeatNumber(input));
            //Console.WriteLine(new Program().FindRepeatNumberDictionary(input));
            //Console.WriteLine(new Program().FindRepeatNumberLinq(input));
        }

        //排序解法，较快，较节省空间
        public int FindRepeatNumber(int[] nums)
        {
            //先判断数组里的数是否都符合要求
            //if (Array.Exists(nums, x => x < 0 || x > nums.Length)) return -1;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == nums[i + 1])
                    return nums[i];
            }
            return -1;
        }

        //哈希表解法，最快，最消耗空间
        public int FindRepeatNumberDictionary(int[] nums)
        {
            //先判断数组里的数是否都符合要求
            //if (Array.Exists(nums, x => x < 0 || x > nums.Length)) return -1;
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                //冲突则说明重复了
                if (hs.Contains(nums[i]))
                    return nums[i];
                else
                    hs.Add(nums[i]);
            }
            return -1;
        }

        //LINQ解法，较慢，较消耗空间
        public int FindRepeatNumberLinq(int[] nums)
        {
            //先判断数组里的数是否都符合要求
            //if (Array.Exists(nums, x => x < 0)) return -1;

            //构建查询表达式，思想是按照每个数字进行分组，组内结果多于一个则重复
            var duplications = (from i in nums.GroupBy(n => n)
                                where i.Count() > 1
                                select i.ElementAt(0))
                               .ToArray();
            if (duplications.Length > 0) return duplications[0];
            return -1;
        }
    }
}