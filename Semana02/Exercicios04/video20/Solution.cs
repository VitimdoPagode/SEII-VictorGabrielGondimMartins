using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace video20
{
    public class Solution
    {
        public int[] TwoSum(in[] nums, int target)
        {
            Dictionary<int, int> dict = new();
            for(int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if(dict.ContainsKey(complement))
                {
                    return new int[] {dict[complement], i};
                }
                if(!dict.ContainsKey(complement))
                {
                    dict.Add(nums[i], i);
                }
            }
            throw new ArgumentException("No solution");
        }
    }
}