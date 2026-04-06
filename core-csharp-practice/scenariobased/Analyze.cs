/*2. Scenario: Create a program that analyzes a given paragraph of text. Implement the following
functionalities:
● Count the number of words in the paragraph.
● Find and display the longest word.
● Replace all occurrences of a specific word with another word (case-insensitive).
● Handle edge cases like empty strings or paragraphs with only spaces.*/

using System;
class Analyze
{
    static void Main()
    {
        String a=Console.ReadLine();
        String [] arr=a.Split(' ');
        String replace=Console.ReadLine();
        String replacewith=Console.ReadLine();
        Console.WriteLine(Check(a));
        Console.WriteLine(Word(arr));
        Console.WriteLine(Rep(arr,replace,replacewith));
        Console.WriteLine(IsEmptyOrSpaces(a));


    }

    static int Check(String a)
    {
       int count=0;
        for(int i=0;i<a.Length;i++)
        {
            if(a[i]!=' ')
            {
                  count++;  
                
            }
        }
        return count;
    }
    static String Word(String[] arr)
    {
        int max=0;
        String e = "";
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i].Length>max)
            {
                max=arr[i].Length;
                e=arr[i];
            }  
        }
        return e;
    }
    static String Rep(String [] arr,String replace,String replacewith)
    {
        String k="";
        for(int i=0;i<arr.Length;i++)
        {
        if(arr[i]==replace)
        {
            arr[i]=replacewith;
            k=k+arr[i];
        }
        else{
            k=k+arr[i];
        }
        k=k+" ";
        }
        return k;

    
        }
        static bool IsEmptyOrSpaces(string a)
{
    if (a == null)
        return true;

    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] != ' ')
        {
            return false;   // found a non-space character
        }
    }
    return true;  // only spaces or empty
}

    }
