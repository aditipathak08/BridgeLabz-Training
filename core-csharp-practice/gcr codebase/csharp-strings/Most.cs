

class Most{
    static void Main()
    {
        String a=Console.ReadLine();
        Console.WriteLine(Freq(a));
        


    }
    static char Freq(String a)
    {
    int maxcount=0;
    char Char= ' '; 
    
    for(int i=0;i<a.Length;i++)
    {
        int count=0;
       for(int j=0;j<a.Length;j++)
       {
        if(a[i]==a[j])
        {
            count++;
        }

       }
       if(count > maxcount)
       {
        maxcount=count;
        Char=a[i];
       }
    }
       return Char;


    }
    }
