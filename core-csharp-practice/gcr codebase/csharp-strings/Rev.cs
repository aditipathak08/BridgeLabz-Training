

uusing System;

class Rev
{
    static void Main()
    {
        string s = Console.ReadLine();
        string j = Reve(s);
        Console.WriteLine(j);
    }

    static string Reve(string s)
    {
        string a = "";

        for (int i = s.Length - 1; i >= 0; i--)
        {
            a = a + s[i];
        }

        return a;
    }
}
