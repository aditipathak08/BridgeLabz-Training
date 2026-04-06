
using System;
class Remove
{
    static void Main()
    {
        String a=Console.ReadLine();
        char Ch=Console.ReadLine()[0];
         string result = Rem(a, Ch);
        Console.WriteLine(result);

    }
    static String Rem(String a,Char Ch)
    {
        String s = "";
        for(int i=0;i<a.Length;i++)
        {
            if(a[i]!=Ch)
            {
                s=s+a[i];


            }

        }
        return s;
    }
}