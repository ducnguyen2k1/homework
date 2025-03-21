using System;

class Program
{
    static void Main() {
        int[] arr = new int[10];

        Console.WriteLine("mang ban dau Value: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("x la so can chen: ");
        int X = int.Parse(Console.ReadLine());

        Console.WriteLine("nhap index (0 -> 9) can chen X: ");
        int index = int.Parse(Console.ReadLine());

        if (index < 1 || index >= arr.Length - 1)
        {
            Console.WriteLine("khong the chen phan tu.");
            return;
        }

        for (int i = arr.Length - 1;i > index; i--)
        {
            arr[i] = arr[i - 1];
        }
        arr[index] = X;

        Console.WriteLine("dung new Value (mang sau khi chen: ");
        for(int i = 0;i < arr.Length; i++)
        {
            Console.WriteLine(arr[i] + "");
        }
        PrintArray(arr);
    }
    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}