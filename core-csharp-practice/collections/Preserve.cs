// 4. Remove Duplicates While Preserving Order
// Remove duplicate elements from a list while maintaining the original order.
// Example:
// Input: [3, 1, 2, 2, 3, 4]
// Output: [3, 1, 2, 4]

using System;
using System.Numerics;
class Preserve
{
    static void Main()
    {
        HashSet<int> seen=new HashSet<int>();
        List<int> list=new List<int>();
        list.Add(3);
        list.Add(1);
        list.Add(2);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        List<int> updated=new List<int>();
        for(int i=0;i<list.Count;i++)
        {
            if(!seen.Contains(list[i]))
            {
                seen.Add(list[i]);
               updated.Add(list[i]);
            }
        }
            for(int i=0;i<updated.Count;i++)
            {
            Console.Write(updated[i] + " " );
            }
        
    }
}