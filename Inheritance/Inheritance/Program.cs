using System;

class Vehicle {
    public int noOfTyres;
}

class Car : Vehicle
{
    string name;
    public Car(string name, int tyres)
    {
        this.noOfTyres = tyres;
        this.name = name;
    }
    public void show()
    {
        Console.WriteLine($"{name} has {noOfTyres}");
    }
}

class Bike : Vehicle
{
    string name;
    public Bike(string name, int tyres)
    {
        this.name = name;
        this.noOfTyres = tyres;
    }
    public void show()
    {
        Console.WriteLine($"{name} has {noOfTyres}");
    }
}


class Program
{
    public static void Main(String[] args)
    {
        Car ferarri = new Car("Ferarri", 4);
        Bike kawasaki = new Bike("Kawasaki", 2);

        ferarri.show();
        kawasaki.show();
    }
}