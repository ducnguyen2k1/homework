using System;
class Program
{
    static void Main()
    {
        double height;
        double weight;

        Console.WriteLine("please enter a height:");
            height = float.Parse(Console.ReadLine());
        Console.WriteLine("please enter a your weight");
        weight = float.Parse(Console.ReadLine());

        double bmi = weight / Math.Pow(2, height);
        bmi = Math.Round(bmi, 1);

        Console.Write("BMI: " + bmi);

        if (bmi < 18)
            Console.WriteLine(" Underweight");
        else if (bmi < 25.0)
            Console.WriteLine(" Normal");
        else if (bmi < 30.0)
            Console.WriteLine(" Overweight");
        else
            Console.WriteLine(" Obese");
    }
}