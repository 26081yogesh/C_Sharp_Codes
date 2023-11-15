using System;
class Program
{
    static void test()
    {
        int a = 0;
        if(a == 0)
        {
            throw new ArithmeticException();
        }
        
    }
    public static void Main(string[] args)
    {
        /* try
        {
            int a = 10;
            int b = 0;
            int c = a / b;
        }
        catch(Exception e)
        {
            Console.WriteLine("Cannot divide by 0 :- " + e.Message);
        }
        finally
        {
            Console.WriteLine("END OF PROGRAM");
        } */
        try
        {
            test();
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}