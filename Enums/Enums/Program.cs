using System;
class Program
{
    enum Months
    {
        january, february, march, april, may, june, july, august, september, october, november, december
    }
    public static void Main(String[] args)
    {
        Months month = Months.january;
        switch (month)
        {
            case Months.january:
                Console.WriteLine("31 Days");
                break;
            case Months.february:
                Console.WriteLine("28 Days");
                break;
            case Months.march:
                Console.WriteLine("31 Days");
                break;
            case Months.april:
                Console.WriteLine("30 Days");
                break;
            case Months.may:
                Console.WriteLine("31 Days");
                break;
            case Months.june:
                Console.WriteLine("30 Days");
                break;
            case Months.july:
                Console.WriteLine("31 Days");
                break;
            case Months.august:
                Console.WriteLine("31 Days");
                break;
            case Months.september:
                Console.WriteLine("30 Days");
                break;
            case Months.october:
                Console.WriteLine("31 Days");
                break;
            case Months.november:
                Console.WriteLine("30 Days");
                break;
            case Months.december:
                Console.WriteLine("31 Days");
                break;
        }
    }
}