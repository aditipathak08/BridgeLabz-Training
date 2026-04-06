 /*82. Scenario: Develop a program to manage student test scores. The program should:
 ● Store the scores of n students in an array.
 ● Calculate and display the average score.
 ● Find and display the highest and lowest scores.
 ● Identify and display the scores above the average.
 ● Handle invalid input like negative scores or non-numeric input*/

 using System;
 class Third
 {
    static void Main()
    {
        int students=int.Parse(Console.ReadLine());
           int [] arr=new int[students];
           for(int i=0;i<students;i++)
           {
            arr[i] = int.Parse(Console.ReadLine());
           }
        Console.WriteLine(Score(arr));
        Console.WriteLine(HighLow(arr));
        Console.WriteLine(Above(arr));


    }
    static int Score(int[] arr)
    {
        int total=0;
        for(int i=0;i<arr.Length;i++)
        {
            total=total+arr[i];
        }
        return total/arr.Length;
    }
        static void HighLow(int[] arr)
        {
    int high = arr[0];
    int low = arr[0];

    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > high)
            high = arr[i];

        if(arr[i] < low)
            low = arr[i];
    }

    Console.WriteLine("Highest marks: " + high);
    Console.WriteLine("Lowest marks: " + low);
        }
      static void Above(int[] arr)
{
    int total = 0;

    for(int i = 0; i < arr.Length; i++)
    {
        total += arr[i];
    }

    int avg = total / arr.Length;
    Console.WriteLine("Average = " + avg);

    Console.WriteLine("Marks above average:");
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > avg)
            Console.WriteLine(arr[i]);
    }
}
 }