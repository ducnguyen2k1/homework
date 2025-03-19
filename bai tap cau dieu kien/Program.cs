using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhap so khong am (3 chu so): ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0 || number > 999)
        {
            Console.WriteLine("Out of ability");
        }
        else
        {
            Console.WriteLine(NumberToWords(number));
        }
    }

    static string NumberToWords(int number)
    {
        if (number == 0)
            return "zero";

        string words = "";

        if (number >= 100)
        {
            int hundreds = number / 100;
            number %= 100;

            switch (hundreds)
            {
                case 1: words += "one hundred"; break;
                case 2: words += "two hundred"; break;
                case 3: words += "three hundred"; break;
                case 4: words += "four hundred"; break;
                case 5: words += "five hundred"; break;
                case 6: words += "six hundred"; break;
                case 7: words += "seven hundred"; break;
                case 8: words += "eight hundred"; break;
                case 9: words += "nine hundred"; break;
            }

            if (number > 0)
                words += " and ";
        }

        if (number >= 20)
        {
            int tens = number / 10;
            number %= 10;

            switch (tens)
            {
                case 2: words += "twenty"; break;
                case 3: words += "thirty"; break;
                case 4: words += "forty"; break;
                case 5: words += "fifty"; break;
                case 6: words += "sixty"; break;
                case 7: words += "seventy"; break;
                case 8: words += "eighty"; break;
                case 9: words += "ninety"; break;
            }

            if (number > 0)
                words += " ";
        }

        
        if (number >= 10)
        {
            switch (number)
            {
                case 10: words += "ten"; break;
                case 11: words += "eleven"; break;
                case 12: words += "twelve"; break;
                case 13: words += "thirteen"; break;
                case 14: words += "fourteen"; break;
                case 15: words += "fifteen"; break;
                case 16: words += "sixteen"; break;
                case 17: words += "seventeen"; break;
                case 18: words += "eighteen"; break;
                case 19: words += "nineteen"; break;
            }
        }
        
        else if (number > 0)
        {
            switch (number)
            {
                case 1: words += "one"; break;
                case 2: words += "two"; break;
                case 3: words += "three"; break;
                case 4: words += "four"; break;
                case 5: words += "five"; break;
                case 6: words += "six"; break;
                case 7: words += "seven"; break;
                case 8: words += "eight"; break;
                case 9: words += "nine"; break;
            }
        }

        return words;
    }
}


