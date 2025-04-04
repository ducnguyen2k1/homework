using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("=== step 1 ===");
        double[,] matrix = new double[3, 3] 
        {
            { 1.5, 2.3, 3.1 },
            { 4.7, 5.6, 6.2 },
            { 7.3, 8.4, 9.9 }
        };

        double max = matrix[0, 0]; 
        int maxRow = 0, maxCol = 0; 

        
        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
            for (int j = 0; j < matrix.GetLength(1); j++) 
            {
                if (matrix[i, j] > max) 
                {
                    max = matrix[i, j];
                    maxRow = i;
                    maxCol = j;
                }
            }
        }

       
        Console.WriteLine($"phan tu lon nhat trong ma tran: {max}");
        Console.WriteLine($"toa do phan tu lon nhat: hang {maxRow}, cot {maxCol}");

        Console.WriteLine();

     
        Console.WriteLine("=== step 2 ===");

        
        Console.Write("nhap so hang ma tran: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("nhap so cot ma tran: ");
        int cols = int.Parse(Console.ReadLine());

       
        double[,] userMatrix = new double[rows, cols];

       
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Nhap gia tri phan tu [{i}, {j}]: ");
                userMatrix[i, j] = double.Parse(Console.ReadLine());
            }
        }

      
        double userMax = userMatrix[0, 0];
        int userMaxRow = 0, userMaxCol = 0;

        for (int i = 0; i < userMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < userMatrix.GetLength(1); j++)
            {
                if (userMatrix[i, j] > userMax)
                {
                    userMax = userMatrix[i, j];
                    userMaxRow = i;
                    userMaxCol = j;
                }
            }
        }

        
        Console.WriteLine($"phan tu ban nhap lon nhat la: {userMax}");
        Console.WriteLine($"toa do phan tu lon nhat: hang {userMaxRow}, cot {userMaxCol}");
    }
}