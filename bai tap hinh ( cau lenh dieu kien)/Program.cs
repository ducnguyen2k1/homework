using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Menu:");
        Console.WriteLine("1. In hinh chu nhat");
        Console.WriteLine("2. In hình tam giac vuong (Bottom-left)");
        Console.WriteLine("3. In hình tam giac vuong (Top-left)");
        Console.WriteLine("4. In hình tam giac can");
        Console.Write("chon hinh: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                PrintRectangle();
                break;
            case 2:
                PrintRightAngleTriangleBottomLeft();
                break;
            case 3:
                PrintRightAngleTriangleTopLeft();
                break;
            case 4:
                PrintIsoscelesTriangle();
                break;
            default:
                Console.WriteLine("khong hop le!");
                break;
        }
    }

   
    static void PrintRectangle()
    {
        Console.WriteLine("In hinh chu nhat:");
        int length = 4;  
        int width = 7;   

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static void PrintRightAngleTriangleBottomLeft()
    {
        Console.WriteLine("In hình tam giac vuong (Bottom-left):");
        int rows = 5;

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    
    static void PrintRightAngleTriangleTopLeft()
    {
        Console.WriteLine("In hình tam giac vuong (Top-left):");
        int rows = 5;

        for (int i = rows; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    
    static void PrintIsoscelesTriangle()
    {
        Console.WriteLine("In hình tam giac can:");
        int rows = 5;

        for (int i = 1; i <= rows; i++)
        {
            
            for (int j = i; j < rows; j++)
            {
                Console.Write("  ");
            }

            
            for (int j = 1; j <= (2 * i - 1); j++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }
    }
}
