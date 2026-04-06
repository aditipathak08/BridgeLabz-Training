class Ques3
{
    static void Main()
    {
        String a=Console.ReadLine();
        Characters(a);
        

    }

    static void Characters(String a)
    {
        for(int i=0;i<a.Length;i++)
        {
            Console.WriteLine(a[i]);

        }

    }
}