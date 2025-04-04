using System;

class Program
{

    static int CountCharacterOccurrences(string str, char ch)
    {
        int count = 0; 
        
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ch) 
            {
                count++; 
            }
        }
        return count; 
    }

    static void Main(string[] args)
    {
        
        string str = "Hello, how are you today?";

        
        Console.Write("ky tu can dem: ");
        char characterToCount = Console.ReadKey().KeyChar; 
        Console.WriteLine(); 

        
        int count = CountCharacterOccurrences(str, characterToCount);

        
        Console.WriteLine($"Ky tu '{characterToCount}' xuat hien {count} lan trong chuoi.");
    }
}

