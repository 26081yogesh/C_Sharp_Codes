using System;

class Vehicle
{
    public void show()
    {
        Console.WriteLine("Vehicle");
    }
}

class Car : Vehicle
{
    string name;
    public Car(string name)
    {
        this.name = name;
    }

    // Overriding show() method
    public void show()
    {
        Console.WriteLine(this.name);
    }
}

class Extra
{
    public void add(int num1, int num2)
    {
        Console.WriteLine(num1 + num2);
    }

    // Method Overloading
    public void add(int num1, int num2, int num3)
    {
        Console.WriteLine(num1 + num2 + num3);
    }
}

class Program
{
    public static void Main(String[] args)
    {
        Vehicle v = new Vehicle();
        Car c = new Car("Ferarri");

        v.show();
        c.show();


        Extra e = new Extra();
        e.add(1, 2);
        e.add(1, 2, 3);
    }
}