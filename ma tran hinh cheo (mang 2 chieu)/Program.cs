using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Nhap kich thuoc cua ma tran (n): ");
        int n = int.Parse(Console.ReadLine());

        double[,] matrix = new double[n, n];

        
        Console.WriteLine("Nhap phan tu ma tran:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Nhap phan tu o vi tri [{i + 1}, {j + 1}]: ");
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }

      
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += matrix[i, i];  
        }

        Console.WriteLine($"Tong cac phan tu cheo chinh: {sum}");
    }
}

