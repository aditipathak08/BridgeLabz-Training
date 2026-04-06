

using System;
class Occur
{
    static void Main()
    {
     String str=Console.ReadLine();
     String sub=Console.ReadLine();
     int j=Check(str,sub);
     Console.WriteLine(j);
    }
    static int Check(String str,String sub )
    {
        int count=0;
        for(int i=0;i<=str.Length-sub.Length;i++)
        {
        if(str.Substring(i,sub.Length)==sub)
        {
            count++;
        }
        }
        return count;

    }

    }
