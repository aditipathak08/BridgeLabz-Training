using System;

class Temperature
{
    static void Main()
    {
        float[,] temp = new float[7, 24];

        // Taking input
        Console.WriteLine("Enter temperature values:");
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("Day " + (i + 1));
            for (int j = 0; j < 24; j++)
            {
                temp[i, j] = float.Parse(Console.ReadLine());
            }
        }

        AnalyzeTemperature(temp);
    }

    static void AnalyzeTemperature(float[,] temp)
    {
        int days = 7;
        int hours = 24;

        float maxAvg = float.MaxValue * -1;
        float minAvg = float.MaxValue;

        int hotDay = 0;
        int coldDay = 0;

        for (int i = 0; i < days; i++)
        {
            float sum = 0;

            for (int j = 0; j < hours; j++)
            {
                sum = sum + temp[i, j];
            }

            float avg = sum / hours;
            Console.WriteLine("Day " + (i + 1) + " Average = " + avg);

            if (avg > maxAvg)
            {
                maxAvg = avg;
                hotDay = i;
            }

            if (avg < minAvg)
            {
                minAvg = avg;
                coldDay = i;
            }
        }

        Console.WriteLine("\nHottest Day = Day " + (hotDay + 1));
        Console.WriteLine("Coldest Day = Day " + (coldDay + 1));
    }
}
