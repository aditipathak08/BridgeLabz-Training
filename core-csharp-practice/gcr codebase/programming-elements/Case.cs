/*7. Toggle Case of Characters
Problem:
Write a C# program to toggle the case of each character in a given string. Convert
uppercase letters to lowercase and vice versa.*/

using System;
class Case
{
    static void Main()
    {
        String a=Console.ReadLine();
        String j=Casecheck(a);
    }
    static String Casecheck()
    {
        String s="";
        //A=65 a=97
        for(int i=0;i<a.Length;i++)
        {
            if(a[i]<'a')
            {
                s=(char)a[i]+32;
            }
            s=(char)a[i]-32;
            
        }
        return s;
        
    }
}
