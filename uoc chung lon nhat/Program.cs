﻿using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        a = Math.Abs(a);
        b = Math.Abs(b);

        if (a == 0 || b == 0)
        {
            Console.WriteLine("No greatest common factor");
            return;
        }
        
        while (a != b)
        {
            if (a > b)
            {
                a = a - b;
            }
            else
                b = b - a;
        }
        Console.WriteLine("Greatest common factor: " + a);
    }
}
