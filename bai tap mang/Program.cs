using System;

class Program
{
    public int number;
    public string nameStr = null;

    public static void Main(string[] args)
    {
        int[] arrNames = null;
        arrNames = new int[] { 5, 7, 9 };
        arrNames = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        arrNames = new int[5] { 1, 2, 4, 4, 5 };
        arrNames = new int[5];
        string[] arrStr;
        arrNames[1] = 3;
        for (int i = 0; i < arrNames.Length; i++)
        {
            Console.WriteLine(arrNames[i]);
        }

        foreach (int value in arrNames)
        {
            Console.WriteLine("value");
        }

        int number1;
        number1 = 2;
    }
}

