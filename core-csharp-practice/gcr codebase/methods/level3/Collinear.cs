using System;
class Collinear{
    public static bool SlopeMethod(double x1,double y1,double x2,double y2,double x3,double y3){
        double m1=(y2-y1)/(x2-x1);
        double m2=(y3-y2)/(x3-x2);
        double m3=(y3-y1)/(x3-x1);
        if(m1==m2 && m2==m3) return true;
        else return false;
    }

    public static bool AreaMethod(double x1,double y1,double x2,double y2,double x3,double y3){
        double area=0.5*(x1*(y2-y3)+x2*(y3-y1)+x3*(y1-y2));
        if(area==0) return true;
        else return false;
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
        Console.WriteLine("Enter x3 : ");
        double x3=double.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter y3 : ");
        double y3=double.Parse(Console.ReadLine()!);

        if(SlopeMethod(x1,y1,x2,y2,x3,y3)) Console.WriteLine("Points are collinear (Slope Method)");
        else Console.WriteLine("Points are not collinear (Slope Method)");

        if(AreaMethod(x1,y1,x2,y2,x3,y3)) Console.WriteLine("Points are collinear (Area Method)");
        else Console.WriteLine("Points are not collinear (Area Method)");
    }
}