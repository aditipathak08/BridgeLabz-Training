using System;
class Program
{
    static void Main()
    {
        try
        {
        double armPrecision=double.Parse(Console.ReadLine());
        int workerDensity=int.Parse(Console.ReadLine());
        string machineryState=Console.ReadLine();
        Analyser ad=new Analyser();
        double result=ad.CalculateHazardRisk(armPrecision,workerDensity,machineryState);
        Console.WriteLine("Robot Hazard Risk Score: "+result);
        }
        catch(RobotSafetyException e)
        {
            Console.WriteLine(e.Message);
        }
        
   }
}