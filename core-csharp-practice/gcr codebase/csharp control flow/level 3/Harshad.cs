using System;

class Harshad
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int s = 0;
        int ori = n; 
        int o = n;

        while(o != 0)
        {
            int r = o % 10;
            s += r;
            o /= 10; 
        }

        if(ori % s == 0)
        {
            Console.WriteLine("Harshad");
        }
        else
        {
            Console.WriteLine("Not a Harshad");
        }
    }
}
