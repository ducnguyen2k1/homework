using System;

namespace TimeLine
{
    class Program
    {
      
        static void Main()
        {
              float width, height;
            Console.Write("Enter width: ");
            width = float.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            height = float.Parse(Console.ReadLine());
            float area = width * height;
            Console.WriteLine("Area is: " + area );
        }
    }
}