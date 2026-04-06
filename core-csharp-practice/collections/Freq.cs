using System.Collections.Generic;
using System;
class Freq
{
    static void Main()
    {
        List<string> list=new List<string>();
        list.Add("apple");
        list.Add("banana");
        list.Add("apple");
        list.Add("orange");
        Dictionary <string,int> freq=new Dictionary<string,int>();
        for(int i=0;i<list.Count;i++)
        {
            if(freq.ContainsKey(list[i]))
            {
                freq[list[i]]=freq[list[i]]+1;
            }
            else
            {
                freq[list[i]]=1;
            }
        }
        List<string>keys=new List<string>(freq.Keys);
        for(int i=0;i<keys.Count;i++)
        {
            Console.WriteLine(keys[i] + " " + freq[keys[i]]);
        }

    }
}