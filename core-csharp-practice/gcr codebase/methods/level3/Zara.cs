using System;
class Zara{
    public static int[,] SalaryYears(){
        int[,] arr=new int[10,2];
        Random r=new Random();
        for(int i=0;i<10;i++){
            arr[i,0]=r.Next(10000,100000);   // salary 5-digit
            arr[i,1]=r.Next(1,11);           // years of service 1-10
        }
        return arr;
    }

    public static double[,] CalculateBonus(int[,] arr){
        double[,] newArr=new double[10,3];
        for(int i=0;i<10;i++){
            int sal=arr[i,0];
            int yrs=arr[i,1];
            double bonus=(yrs>5)? sal*0.05 : sal*0.02;  // 5% or 2%
            newArr[i,0]=sal;
            newArr[i,1]=bonus;
            newArr[i,2]=sal+bonus;
        }
        return newArr;
    }

    public static void DisplayTotals(double[,] arr){
        double oldTotal=0,newTotal=0,bonusTotal=0;
        Console.WriteLine("Old Salary\tBonus\tNew Salary");
        for(int i=0;i<10;i++){
            Console.WriteLine(Math.Round(arr[i,0],2)+"\t\t"+Math.Round(arr[i,1],2)+"\t"+Math.Round(arr[i,2],2));
            oldTotal+=arr[i,0];
            bonusTotal+=arr[i,1];
            newTotal+=arr[i,2];
        }
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Total\t\t"+Math.Round(bonusTotal,2)+"\t"+Math.Round(newTotal,2));
        Console.WriteLine("Sum of old salaries = "+Math.Round(oldTotal,2));
    }

    static void Main(){
        int[,] emp=SalaryYears();
        double[,] updated=CalculateBonus(emp);
        DisplayTotals(updated);
    }
}