using System;
using System.Collections.Generic;
public class CountOccurences
{
    public static int[] ary = new int[] { 1, 2, 3, 4, 1, 3, 2, 4 ,1,1,3};

    public static void FindOccurenceCount()
    {
        Dictionary<int, int> o = new Dictionary<int, int>();
        foreach (int item in ary)
        {
            if (!o.ContainsKey(item))
            {
                o.Add(item, 1);
            }
            else
            {
                o[item] = o[item] + 1;
            }
        }
        foreach (var item in o)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }

}
