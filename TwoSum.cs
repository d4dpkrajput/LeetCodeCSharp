using System;
using System.Collections.Generic;

public class TwoSum
{
    public static int[] nums = new int[] { 2, 7, 11, 5 };
    public static int target = 18;
    public static int[] Indices()
    {
        Dictionary<int, int> d = new Dictionary<int, int>();
        int[] res = new int[]{};
        for (int i = 0; i < nums.Length; i++)
        {
            if(d.ContainsKey(target-nums[i]))   // n 
            {
                return new int[]{i, d[target-nums[i]]};
            }
            d.Add(nums[i],i);
        }
        return new int[]{};
    }
}
