using System;
class Program
{
    public void Main()
    {
        Console.WriteLine("Which month that you want to count days? ");
        int month = Int32.Parse(Console.ReadLine());

    }
        public static void Main(String[] args)
        {
            Console.WriteLine("Which month that you want to count days? ");
            int month = Int32.Parse(Console.ReadLine());
            switch (month)
            {
                case 2:
                    Console.WriteLine("The month '2' has 28 or 29 days!");
                    break;
                case 1:
                Console.WriteLine("The month '" + month + "' has 31 days!");
                break;
                case 3:
                Console.WriteLine("The month '" + month + "' has 31 days!");
                break;
            }
        switch (month) 
        {
            case 2:
                Console.WriteLine("The month '2' has 28 or 29 days!");
                break;
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("The month '" + month + "' has 31 days!");
                break;
        }
        string daysinmonth;
        switch (month)
        {
            case 2:
                daysinmonth = "28 or 29";
                break;
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                daysinmonth = "31";
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                daysinmonth = "30";
                break;
            default:
                daysinmonth = "";
                break;
        }

        if (daysinmonth != "")
        {
            Console.WriteLine("The month {0} has {1} days!", month, daysinmonth);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
        }   
}
