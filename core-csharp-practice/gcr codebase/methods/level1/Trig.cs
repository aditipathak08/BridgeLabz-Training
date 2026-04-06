using System;

class Trig
{
    // Method to calculate sin, cos, tan
    public static void CalculateTrig(double angleInDegrees)
    {
        // Convert degrees to radians
        double angleInRadians = angleInDegrees * (Math.PI / 180);

        // Calculate sin, cos, tan
        double sinValue = Math.Sin(angleInRadians);
        double cosValue = Math.Cos(angleInRadians);
        double tanValue = Math.Tan(angleInRadians);

        // Print results
        Console.WriteLine("Sine({0}°) = {1}", angleInDegrees, sinValue);
        Console.WriteLine("Cosine({0}°) = {1}", angleInDegrees, cosValue);
        Console.WriteLine("Tangent({0}°) = {1}", angleInDegrees, tanValue);
    }

    static void Main()
    {
        Console.Write("Enter an angle in degrees: ");
        double angle = double.Parse(Console.ReadLine());

        // Call the method
        CalculateTrig(angle);
    }
}
