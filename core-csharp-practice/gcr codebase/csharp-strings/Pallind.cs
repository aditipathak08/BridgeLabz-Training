using System;
class Pallind
{
    static void Main()
    {
        String a=Console.ReadLine();
        bool j=Check(a);
        Console.WriteLine(j);

    }
    static bool Check(String a)
    {
        String s="";
        for(int i=a.Length-1;i>=0;i--)
        {
            s=s+a[i];
        }
            if(a==s)
            {
                return true;
            }
            return false;

        }
    }