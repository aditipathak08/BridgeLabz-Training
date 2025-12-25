using System;
class CalendarProgram{
    public static string MonthName(int m){
        string[] months={"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"};
        return months[m-1];
    }

    public static bool LeapYear(int y){
        if(y%4==0 && y%100!=0 || y%400==0) return true;
        else return false;
    }

    public static int DaysInMonth(int m,int y){
        int[] days={31,28,31,30,31,30,31,31,30,31,30,31};
        if(m==2 && LeapYear(y)) return 29;
        else return days[m-1];
    }

    public static int FirstDay(int m,int y){
        int d=1;
        int y0=y - (14-m)/12;
        int x=y0 + y0/4 - y0/100 + y0/400;
        int m0=m + 12*((14-m)/12) -2;
        int d0=(d + x + (31*m0)/12)%7;
        return d0;
    }

    static void Main(){
        Console.WriteLine("enter month (1-12) : ");
        int m=int.Parse(Console.ReadLine());
        Console.WriteLine("enter year : ");
        int y=int.Parse(Console.ReadLine());

        int days=DaysInMonth(m,y);
        int start=FirstDay(m,y);

        Console.WriteLine("   "+MonthName(m)+" "+y);
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        for(int i=0;i<start;i++){
            Console.Write("    ");   // 4 spaces for alignment
        }

        for(int i=1;i<=days;i++){
            Console.Write(i.ToString().PadLeft(3)+" ");
            if((i+start)%7==0) Console.WriteLine();
        }
        Console.WriteLine();
    }
}