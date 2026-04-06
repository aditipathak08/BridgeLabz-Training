using System;
class Ques2
{
    static void Main()
    {
        String a=Console.ReadLine();
        int start=int.Parse(Console.ReadLine());
        int end=int.Parse(Console.ReadLine());
        String s=Subs(a,start,end);
        Console.WriteLine(s);
    }

    static String Subs(String a,int start,int end)
    {
        String s= "";
        for(int i=start;i<end;i++)
        {
            s = s +a[i];
            
        }
        return s;
    }
}
