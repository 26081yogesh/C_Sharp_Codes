using System;

abstract class CreateTea
{
    public void makingTea()
    {
        Console.WriteLine("Let's Make Tea Guys!!!!");
    }
    public abstract void boilWater();
    public abstract void addTeaLeaves();
    public abstract void addSugar();
    public abstract void addMilk();
    public abstract void finish();
}

class Making : CreateTea
{
    public override void boilWater()
    {
        Console.WriteLine("Boiling Water");
    }
    public override void addTeaLeaves()
    {
        Console.WriteLine("Adding Tea Leaves");
    }
    public override void addSugar()
    {
        Console.WriteLine("Adding Sugar");
    }

    public override void addMilk()
    {
        Console.WriteLine("Adding Milk");
    }

    public override void finish()
    {
        Console.WriteLine("Tea is Ready....");
    }
}

class Program
{
    public static void Main(String[] args)
    {

        Making m = new Making();
        m.makingTea(); 
        m.boilWater();
        m.addTeaLeaves();
        m.addSugar();
        m.addMilk();
        m.finish();
    }
}