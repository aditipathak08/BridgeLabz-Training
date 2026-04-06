

class Longest 
{
    static void Main()
    {
    String a=Console.ReadLine();
    String[] arr=a.Split(' ');
    String j=Sentence(arr);
    Console.WriteLine(j);

    }
    static String Sentence(String [] arr)
    {
        int max=0;
        String e= "";
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
}