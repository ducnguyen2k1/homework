using System;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            double rate = 23000;

            double usd;

            Console.WriteLine("print USD money: ");
            usd = Convert.ToDouble(Console.ReadLine());

            double vnd = usd * rate;

            Console.WriteLine($" number money {usd} USD is {vnd} VND.");
        }
    }    
}