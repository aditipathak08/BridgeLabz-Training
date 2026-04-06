using System;
class Dupli
{
    static void Main()
    {
        String a=Console.ReadLine();
        String j=Duplicate(a);
        Console.WriteLine(j);
    }
    static String Duplicate(String a)
    {
        String s="";
        for(int i=0;i<a.Length;i++)
        {
            if(!s.Contains(a[i]))
            {
            s=s+a[i];
            
            }
             
            
        }
        return s;
    }
}