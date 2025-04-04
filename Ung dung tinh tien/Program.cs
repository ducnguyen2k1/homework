using System;
class Program
{
    static void Main()
    {
        double money = 1.0;
        int month = 1;
        double intersetRate = 1.0;

        Console.WriteLine("Enter investment amount: ");
        money = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter number of months: ");
        month = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter annual interest rate in percentage: ");
        intersetRate = double.Parse(Console.ReadLine());

        double totalInterset = 0;
        for (int i = 0; i < month; i++)
        {
            totalInterset += money * (intersetRate / 100) / 12;
        }

        Console.WriteLine("Total of interset: " + totalInterset);

        money = 100000;
        intersetRate = 5.5;
        month = 3;

        totalInterset = 0;
        for (int i = 0;i < month; i++)
        {
            totalInterset += money * (intersetRate / 100) / 12;
        }

        Console.WriteLine("Total interest for 3 months: " + totalInterset);
    }
}