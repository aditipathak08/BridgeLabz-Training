/*Try to solve this problem statement
Strings – Sentence Formatter
1. Scenario: A text editing tool receives poorly formatted input from users. Your task is to auto-correct formatting by fixing spacing and capitalizing the first letter of each sentence.
Problem:
Write a method that takes a paragraph as input and returns a corrected version with:
● One space after punctuation,
● Capital letter after period/question/exclamation marks,
● Trimmed extra spaces.*/


using System;
class  Scenario1
{
    static void Main()
    {
       String [] a=Console.ReadLine().Split('.');
       // this is a book.this is a phone.
       for(int i=0;i<a.Length;i++)
       {
       Console.WriteLine(Check(a[i]));
       }

    }
    static String Check(String a)
    {
        a=a.Trim();
        String s="";
     if((a[0])>='a'&& a[0]<='z')
        {
            s=s+(char)(a[0]-32);
        }
        else
        {
            s=s+(char)a[0];
        }
        for(int i=1;i<a.Length;i++)
        {
            if(a[i]==' ' && a[i-1]== ' '){
            }
            else if(a[i]== ',')
            {
                s=s+a[i]+ ' ';
            }
            else if(a[i]>='A'&& a[i]<='Z')
            {
                s=s+(char)(a[i]+32);
            }
            else
            {
                s=s+a[i];
            }

        }
        return s;

    }
    }
    