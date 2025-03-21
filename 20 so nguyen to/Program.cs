using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Nhap so luong nguyen to: ");
        int numbers = int.Parse(Console.ReadLine());

        
        int count = 0;

        
        int s = 2;

        
        while (count < numbers)
        {
            
            if (IsPrime(s))
            {
                
                Console.Write(s + " ");
                count++;
            }

            // 
            s++;
        }
    }

    
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false; 
        }

        return true; 
    }
}
