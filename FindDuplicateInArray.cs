using System;
using System.Collections.Generic;
public class FindDuplicateInArray
{
    //Given an array of integers, 1<=a[i]<n where n is the size of the array.
    public static int[] ary = new int[] { 5, 3, 2, 7, 5, 2, 3, 1 };
    public static int[] FindDuplicate()
    {
        List<int> res = new List<int>();
        for (int i = 0; i < ary.Length; i++)
        {
            int index =  Math.Abs(ary[i])-1;
            if (ary[index] > 0)
            {
                ary[index] *= -1;
            }
            else
            {
                res.Add(Math.Abs(ary[i]));
            }
        }
        return res.ToArray();
    }
}
