using System;

class ExtensionMethods
{
    public void M1()
    {
        Console.WriteLine("M1");
    }
    public void M2()
    {
        Console.WriteLine("M2");
    }
    public void M3()
    {
        Console.WriteLine("M3");
    }
}

static class NewMethodClass
{
    public static void M4(this ExtensionMethods obj)
    {
        Console.WriteLine("M4");
    }
    public static void M5(this ExtensionMethods obj)
    {
        Console.WriteLine("M5");
    }
}
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Main Method");
        ExtensionMethods obj = new ExtensionMethods();
        obj.M1();
        obj.M2();
        obj.M3();
        obj.M4();
        obj.M5();
    }
}