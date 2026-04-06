//ATM Dispenser Logic
//Context: ATM dispenses minimum number of notes.
// ●  Scenario A: Given ₹1, ₹2, ₹5, ₹10, ₹20, ₹50, ₹100, ₹200, ₹500 notes, find optimal
//combo for ₹880.
// ●  Scenario B: Remove ₹500 temporarily and update strategy.
// ● Scenario C: Display fallback combo if exact change isn’t possible.

using System;
public class Dsa2
{
    static void Main()
    {
        int[] arr = { 1, 2, 5, 10, 20, 50, 100, 200, 500 };
        Console.WriteLine("Enter amount to withdraw");
        //amount = 880
        int amount = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = arr.Length - 2; i >= 0; i--)
        {
            if (amount < 1)
            {
                break;
            }
                Console.WriteLine(arr[i]+"X" + amount / arr[i]);
                count += amount / arr[i];
                amount = amount % arr[i];
            
        }
        Console.WriteLine(count);
        //for second function

    }


}
