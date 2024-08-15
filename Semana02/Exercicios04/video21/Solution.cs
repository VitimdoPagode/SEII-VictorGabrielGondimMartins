using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace video21
{
    public class Solution
    {
        HashSet<int> set = new();
        public bool ContainsDuplicate(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if(set.Contains(nums[i]))
                {
                   return true; 
                }
                set.Add(nums[i]);
            }
            return false;
        }
    }
}