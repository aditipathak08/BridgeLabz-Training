using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first word");
        string a=Console.ReadLine();
        Console.WriteLine("Enter second word");
        string b=Console.ReadLine();
        Utility result=new Utility();
        if(!result.Lexi(a, b))
        {
            if(a.Contains(" "))
            {
                Console.WriteLine(a+ " is an invalid word");
            }
            else if(b.Contains(" "))
            {
                Console.WriteLine(b+" is an invalid word");
            }
            return ;
        }
        string output=result.ProcessWords(a,b);
        Console.WriteLine(output);

    }
}