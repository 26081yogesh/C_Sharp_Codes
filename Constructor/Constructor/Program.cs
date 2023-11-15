using System;

class Animal
{
    public string name;
    public string sound;
    
    // Constructor
    public Animal(string name, string sound)
    {
        this.name = name;
        this.sound = sound;
    }

    public void show()
    {
        Console.WriteLine($"{this.name}  ->  {this.sound}");
    }
}

class Program
{
    public static void Main(String[] args)
    {
        // Object 1
        Animal dog = new Animal("Dog", "Bark");
        Animal lion = new Animal("Lion", "Roar");
        Animal cat = new Animal("Cat", "Meow");

        dog.show();
        lion.show();
        cat.show();
    }
}