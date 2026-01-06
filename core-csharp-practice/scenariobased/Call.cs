using System;

public class Call
{
    public int Phone { get; set; }
    public string Message { get; set; }
    public DateTime Timestamp { get; set; }

    public Call(int phone, string message, DateTime timestamp)
    {
        Phone = phone;
        Message = message;
        Timestamp = timestamp;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{Phone} | {Message} | {Timestamp}");
    }
}

public class Manager
{
    private Call[] calls;
    private int count = 0;

    public Manager(int n) // n = max number of calls
    {
        calls = new Call[n];
    }

    public void AddCallLog(Call call)
    {
        if (count < calls.Length)
        {
            calls[count] = call;
            count++;
        }
        else
        {
            Console.WriteLine("Call log is full!");
        }
    }

    public void SearchByKeyword(string keyword)
    {
        Console.WriteLine($"Searching calls containing '{keyword}':");
        for (int i = 0; i < count; i++)
        {
            if (calls[i].Message.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                calls[i].DisplayInfo();
            }
        }
    }

    public void FilterByTime(DateTime start, DateTime end)
    {
        Console.WriteLine($"Calls between {start} and {end}:");
        for (int i = 0; i < count; i++)
        {
            if (calls[i].Timestamp >= start && calls[i].Timestamp <= end)
            {
                calls[i].DisplayInfo();
            }
        }
    }
}

// Example usage:
class Program
{
    static void Main()
    {
        Manager manager = new Manager(5);

        manager.AddCallLog(new Call(12345, "Hello, how are you?", DateTime.Now));
        manager.AddCallLog(new Call(67890, "Meeting at 5", DateTime.Now.AddMinutes(-30)));
        manager.AddCallLog(new Call(11122, "Call me back", DateTime.Now.AddHours(-1)));

        Console.WriteLine("\nAll logs:");
        manager.FilterByTime(DateTime.Now.AddHours(-2), DateTime.Now);

        Console.WriteLine("\nSearch keyword 'call':");
        manager.SearchByKeyword("call");
    }
}
