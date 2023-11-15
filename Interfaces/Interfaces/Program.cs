using System;

interface CreateTea
{
    void boilWater();
    void addTeaLeaves();
    void addSugar();
    void addMilk();
    void finish();
}

class Making:CreateTea
{
    public void boilWater()
    {
        Console.WriteLine("Boiling Water");
    }
    public void addTeaLeaves()
    {
        Console.WriteLine("Adding Tea Leaves");
    }
    public void addSugar()
    {
        Console.WriteLine("Adding Sugar");
    }

    public void addMilk()
    {
        Console.WriteLine("Adding Milk");
    }

    public void finish()
    {
        Console.WriteLine("Tea is Ready....");
    }
}

class Program
{
    public static void Main(String[] args)
    {

        Making m = new Making();
        m.boilWater();
        m.addTeaLeaves();
        m.addSugar();
        m.addMilk();
        m.finish();
    }
}