
using System;
class Lex
{
    static void Main()
    {
        String a=Console.ReadLine();
        String b=Console.ReadLine();
        String j=Check(a,b);
        Console.WriteLine(j);

    }

    static String Check(String a,String b)
    {
       int min= Math.Min(a.Length, b.Length);
        for(int i=0;i<min;i++)
        {
            if(a[i]>b[i])
            {
                return a;
            }
            else
            {
                return b;
            }

        }
        return "Equal";
        }
    }