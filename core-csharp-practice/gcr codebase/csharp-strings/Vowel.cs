
using System;
class Vowels
{
    static void Main()
    {
        String a=Console.ReadLine();
        FuncVc(a);


        

    }
    static void FuncVc(String a)
    {
        int countvo=0;
        int countco=0;
        for(int i=0;i<a.Length;i++)
        {
            char ch = char.ToLower(a[i]);
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                countvo++;
                
            }
            else if
                (ch >= 'a' && ch <= 'z')
                {
            
                countco++;
            }
        }
            Console.WriteLine("Vowel "+countvo);
            Console.WriteLine("Consonant "+countco);
            
        }
    }
