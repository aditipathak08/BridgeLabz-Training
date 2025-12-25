using System;
class Eucl{
    public static double Distance(double x1,double y1,double x2,double y2){
        double dist=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
        return dist;
    }

    public static double[] LineEquation(double x1,double y1,double x2,double y2){
        double m=(y2-y1)/(x2-x1);       // slope
        double b=y1 - m*x1;             // y-intercept
        double[] arr={m,b};
        return arr;
    }

    static void Main(){
        Console.WriteLine("Enter x1 : ");
        double x1=double.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter y1 : ");
        double y1=double.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter x2 : ");
        double x2=double.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter y2 : ");
        double y2=double.Parse(Console.ReadLine()!);

        double d=Distance(x1,y1,x2,y2);
        Console.WriteLine("Euclidean distance = "+d);

        double[] eq=LineEquation(x1,y1,x2,y2);
        Console.WriteLine("Equation of line: y = "+eq[0]+"*x + "+eq[1]);
    }
}