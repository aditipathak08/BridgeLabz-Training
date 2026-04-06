/*Smart Home Automation System
● Concepts: Appliance, Light, Fan, AC.
● Interface: IControllable(TurnOn, TurnOff).
● Polymorphism: Different behavior for turning on a Light vs AC.*/
//same methods but use for different applications

using System;
class HomeAutomationSystem
{
    static void Main()
    {
        IControllable appliance = new Appliance();
        IControllable light = new Light();
        IControllable fan = new Fan();
        IControllable ac = new AC();
        Console.WriteLine("Turn ON the device");
        appliance.TurnOn();
        light.TurnOn();
        fan.TurnOn();
        ac.TurnOn();
        Console.WriteLine("Turn OFF the device");
        appliance.TurnOff();
        light.TurnOff();
        fan.TurnOff();
        ac.TurnOff();
    }
}
interface IControllable
{
    void TurnOn();
    void TurnOff();
}

public class Appliance:IControllable
{
    public void TurnOn()
    {
        Console.WriteLine("appliance turned on");
    }
    public void TurnOff()
    {
        Console.WriteLine("appliance turned off");
    }
}
public class Light : IControllable
{
    public void TurnOn()
    {
        Console.WriteLine("light turned on");
    }
    public void TurnOff()
    {
        Console.WriteLine("light turned off");
    }
}
public class Fan: IControllable
{
    public void TurnOn()
    {
        Console.WriteLine("Fan turned on");
    }
    public void TurnOff()
    {
        Console.WriteLine("Fan turned off");
    }
}
public class AC: IControllable
{
    public void TurnOn()
    {
        Console.WriteLine("AC turned on");
    }
    public void TurnOff()
    {
        Console.WriteLine("AC turned off");
    }
}