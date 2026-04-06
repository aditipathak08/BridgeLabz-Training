
using System;
class Anag{
    static void Main()
    {
        String a=Console.ReadLine();
        String b=Console.ReadLine();
        Console.WriteLine(Anagram(a,b));
    

    }

    static bool Anagram(String a,String b)
    {
    if(a.Length!=b.Length)
    return false;
        for(int i=0;i<a.Length;i++)
        {
                if(!b.Contains(a[i]))
                {
                    return false;
                }
        }
                for(int i=0;i<b.Length;i++)
                {
                    if(!a.contains(b[i]))
                    {
                        return false;
                    }
                }
        return true;

    }
}

