using System;
class ScoreCard{
    public static int[,] GenerateScores(int n){
        int[,] arr=new int[n,3];
        Random r=new Random();
        for(int i=0;i<n;i++){
            arr[i,0]=r.Next(10,100); // Physics
            arr[i,1]=r.Next(10,100); // Chemistry
            arr[i,2]=r.Next(10,100); // Maths
        }
        return arr;
    }

    public static double[,] CalculateTotalAveragePercentage(int[,] arr){
        int n=arr.GetLength(0);
        double[,] res=new double[n,3]; // Total, Average, Percentage
        for(int i=0;i<n;i++){
            double total=arr[i,0]+arr[i,1]+arr[i,2];
            double avg=total/3;
            double perc=(total/300)*100;
            res[i,0]=Math.Round(total,2);
            res[i,1]=Math.Round(avg,2);
            res[i,2]=Math.Round(perc,2);
        }
        return res;
    }

    public static void DisplayScoreCard(int[,] scores,double[,] res){
        Console.WriteLine("Physics\tChemistry\tMaths\tTotal\tAverage\tPercentage");
        int n=scores.GetLength(0);
        for(int i=0;i<n;i++){
            Console.WriteLine(scores[i,0]+"\t"+scores[i,1]+"\t"+scores[i,2]+"\t"+res[i,0]+"\t"+res[i,1]+"\t"+res[i,2]);
        }
    }

    static void Main(){
        Console.WriteLine("Enter number of students : ");
        int n=int.Parse(Console.ReadLine()!);
        int[,] scores=GenerateScores(n);
        double[,] res=CalculateTotalAveragePercentage(scores);
        DisplayScoreCard(scores,res);
    }
}