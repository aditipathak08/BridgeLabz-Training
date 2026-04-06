using System;

public class Bird
{
    protected string name;
    protected int age;
    protected string species;

    public Bird(string name, int age, string species)
    {
        this.name = name;
        this.age = age;
        this.species = species;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine(name + " " + age + " " + species);
    }
}

interface IFlyable
{
    void Fly();
}

interface ISwimable
{
    void Swim();
}

class Eagle : Bird, IFlyable
{
    public Eagle(string name, int age, string species)
        : base(name, age, species)
    {
    }

    public void Fly()
    {
        Console.WriteLine("Bird can Fly");
    }
}

class Penguin : Bird, ISwimable
{
    public Penguin(string name, int age, string species)
        : base(name, age, species)
    {
    }

    public void Swim()
    {
        Console.WriteLine("Bird can swim");
    }
}

public class Seagull : Bird, IFlyable, ISwimable
{
    public Seagull(string name, int age, string species)
        : base(name, age, species)
    {
    }

    public void Swim()
    {
        Console.WriteLine("can swim");
    }

    public void Fly()
    {
        Console.WriteLine("can fly");
    }
}
class Program
{
    static void Main()
    {
        Bird[] arr = new Bird[3];
        arr[0] = new Eagle("Ari",2,"Eagle");
        arr[1] = new Penguin("Ani",1,"Penguine");
        arr[2] = new Seagull("Ati",3,"Seagull");
        foreach (Bird b in arr)
        {
            b.DisplayInfo();
            if(b is IFlyable)
            {
                ((IFlyable)b).Fly();
            }
            if(b is ISwimable)
            {
                ((ISwimable)b).Swim();
            }
        }
    }
}