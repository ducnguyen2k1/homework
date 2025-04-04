using System;

class Program
{
    
    static int FindElementIndex(int[] arr, int element)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == element)
            {
                return i; 
            }
        }
        return -1; 
    }

    
    static int[] RemoveElement(int[] arr, int indexToDelete)
    {
        int[] newArr = new int[arr.Length - 1]; 
        for (int i = 0, j = 0; i < arr.Length; i++)
        {
            if (i != indexToDelete) 
            {
                newArr[j++] = arr[i]; 
            }
        }
        return newArr; 
    }

    static void Main(string[] args)
    {
        
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        
        Console.Write("Nhap phan tu can xoa: ");
        int elementToDelete = int.Parse(Console.ReadLine());

        
        int indexDel = FindElementIndex(arr, elementToDelete);

        if (indexDel != -1)
        {
          
            Console.WriteLine($"Phan tu {elementToDelete} đuoc tim thay {indexDel}.");
            arr = RemoveElement(arr, indexDel);

            
            Console.WriteLine("Mang sau khi xoa phan tu:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
        else
        {
            Console.WriteLine($"Phan tu {elementToDelete} khong co trong mang.");
        }
    }
}
