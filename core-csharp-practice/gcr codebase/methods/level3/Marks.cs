using System;
class Marks{
    public static int[,] Score(int n){
        int[,] arr=new int[n,3];
        Random r=new Random();
        for(int i=0;i<n;i++){
            arr[i,0]=r.Next(10,100);
            arr[i,1]=r.Next(10,100);
            arr[i,2]=r.Next(10,100);
        }
        return arr;
    }

    public static double[,] Calculate(int[,] arr){
        int n=arr.GetLength(0);
        double[,] a=new double[n,3];
        for(int i=0;i<n;i++){
            double t = arr[i,0]+arr[i,1]+arr[i,2]; // ✅ define total
            a[i,0] = t;
            a[i,1] = t/3;
            a[i,2] = (t/300)*100;
        }
        return a;
    }

    public static void Display(int[,] s,double[,] r){
        Console.WriteLine("Physics\tChemistry\tMaths\tTotal\tAverage\tPercentage");
        int n = s.GetLength(0); // ✅ use parameter
        for(int i=0;i<n;i++){
            Console.WriteLine(s[i,0]+"\t"+s[i,1]+"\t"+s[i,2]+"\t"+r[i,0]+"\t"+r[i,1]+"\t"+r[i,2]);
        }
    }

    static void Main(){
        Console.WriteLine("Enter number of students : ");
        int n=int.Parse(Console.ReadLine()!);
        int[,] scores=Score(n);
        double[,] res=Calculate(scores);
        Display(scores,res); // ✅ correct method call
    }
}