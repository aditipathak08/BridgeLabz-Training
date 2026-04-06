using System;
using System.Collections;
using System.Globalization;
using System.Numerics;
class Reverse
{
    //1 2 4 5 6
    static void Main()
    {
        List<int> list=new List<int>();
        list.Add(1);
        list.Add(3);
        list.Add(4);
        list.Add(5);
        list.Add(9);
        list.Add(2);
        int left=0;
        int right=list.Count-1;
        
        while(left<right)
        {
            int temp=list[left];
            list[left]=list[right];
            list[right]=temp;
            left++;
            right--;
        }
        for(int i=0;i<list.Count;i++)
        {
            Console.Write(list[i] + " ");
        }

    }
}