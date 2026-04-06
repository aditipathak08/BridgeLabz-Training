using System;
class Analyser
{
    public double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)
    {
        if(armPrecision<0.0||armPrecision>1.0)
        {
            throw new RobotSafetyException("Error: Arm precision must be 0.0-1.0");
        }
        if(workerDensity<1||workerDensity>20)
        {
            throw new RobotSafetyException("Error:Worker density must be 1-20");
        }
        if(machineryState!="Worn"&&machineryState!="Faulty"&&machineryState!="Critical")
        {
            throw new RobotSafetyException("Error: Unsupported machinery state");
        }
        double MachineRiskFactor=0;
        if(machineryState=="Worn")
        {
            MachineRiskFactor=1.3; 
        }
        else if(machineryState=="Faulty")
        {
            MachineRiskFactor=2.0; 
        }
        else
        {
            MachineRiskFactor=3.0;
        }
        double HazardRisk=((1.0 - armPrecision) * 15.0) + (workerDensity * MachineRiskFactor);
       return HazardRisk;  
    }

}