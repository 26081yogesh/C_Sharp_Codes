using System;

class Car
{
    public string name;
    public int topSpeed;
    public void run()
    {
        Console.WriteLine($"{name} runs at {this.topSpeed} km/h");
    }

}

class Program
{
    public static void Main(String[] args)
    {
        // Object 1
        Car ferarri = new Car();
        ferarri.name = "Ferarri";
        ferarri.topSpeed = 300;

        // Object 2
        Car mercedes = new Car();
        mercedes.name = "Mercedes";
        mercedes.topSpeed = 200;

        ferarri.run();
        mercedes.run();
    }
}