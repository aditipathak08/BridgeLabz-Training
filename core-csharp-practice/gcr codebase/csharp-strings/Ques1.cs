
using System;
class Ques1
{
    static void Main()
    {
        String a=(Console.ReadLine());
        String b=(Console.ReadLine());
        bool k=Comparebw(a,b);
        if(k==true)
        {
            Console.WriteLine("strings are equal");
        }
            else
            {
            Console.WriteLine("strings are not equal");
            }
        }
        


  
    static bool Comparebw(String a,String b)
    {
        if(a.Length!=b.Length)
        {
            return false;
        }
        for(int i=0;i<a.Length;i++)
        {
            if(a[i]!=b[i])
            {
                return false;
            }

        }
        return true;
    }
}