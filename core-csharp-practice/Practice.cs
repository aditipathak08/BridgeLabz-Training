using System;

class Practice
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine(Add(a, b));
        Check(num);
    }

    static int Add(int a, int b)
    {
        int c = a + b;
        return c;
    }

    static void Check(int num)
    {
        if (num % 2 == 0)
        {
            Console.WriteLine("Number is even");
        }
        else
        {
            Console.WriteLine("Number is odd");
        }
    }
    


}
