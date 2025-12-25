

using System;
class Wind
{
	public double CalculateWindChill(double temperature, double windSpeed)
	{
		double windChill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
		return windChill;
	}
	static void Main()
	{
		Wind w=new Wind();
		double temperature = double.Parse(Console.ReadLine());
		double windSpeed = double.Parse(Console.ReadLine());
		double r=w.CalculateWindChill(temperature, windSpeed);
		Console.WriteLine(r);
	}
}