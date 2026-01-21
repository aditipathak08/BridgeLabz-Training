//3. Rotate Elements in a List
//Rotate the elements of a list by a given number of positions.
//Example:
//Input: [10, 20, 30, 40, 50], rotate by 2
//Output: [30, 40, 50, 10, 20]
using System;
class Rotate
{
    static void Main()
    {
        List<int> list=new List<int>{10,20,30,40,50};
        int k = 2;
        list.Reverse(0,k);
        list.Reverse(k,list.Count - k);
        list.Reverse();
        for(int i=0;i<list.Count;i++)
        {
        Console.Write( (list[i]+" "));
        }
    }
}