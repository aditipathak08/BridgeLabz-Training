using System;
using System.Collections.Generic;
public class ReverseLinkedList
{
    public static void Main()
    {
        LinkedList<int> list = new LinkedList<int>();
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            int value = int.Parse(Console.ReadLine());
            list.AddLast(value);
        }
        LinkedList<int> reversedList = new LinkedList<int>();
        foreach (int item in list)
        {
            reversedList.AddFirst(item);
        }
        Console.WriteLine("Reversed LinkedList:");
        foreach (int item in reversedList)
        {
            Console.Write(item + " ");
        }
    }
}
