using System;

class Program
{
    static void Main()
    {
       
        Console.Write("nhap so can doc (0-999): ");
        int number = int.Parse(Console.ReadLine());

        
        if (number < 0 || number > 999)
        {
            Console.WriteLine("out of ability");
            return;
        }

        
        if (number < 10)
        {
            switch (number)
            {
                case 0: Console.WriteLine("zero"); break;
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
            }
            return;
        }

        
        if (number < 20)
        {
            switch (number)
            {
                case 10: Console.WriteLine("ten"); break;
                case 11: Console.WriteLine("eleven"); break;
                case 12: Console.WriteLine("twelve"); break;
                case 13: Console.WriteLine("thirteen"); break;
                case 14: Console.WriteLine("fourteen"); break;
                case 15: Console.WriteLine("fifteen"); break;
                case 16: Console.WriteLine("sixteen"); break;
                case 17: Console.WriteLine("seventeen"); break;
                case 18: Console.WriteLine("eighteen"); break;
                case 19: Console.WriteLine("nineteen"); break;
            }
            return;
        }

      
        if (number < 100)
        {
            int tens = number / 10;
            int ones = number % 10;

            string result = "";

         
            switch (tens)
            {
                case 2: result += "twenty"; break;
                case 3: result += "thirty"; break;
                case 4: result += "forty"; break;
                case 5: result += "fifty"; break;
                case 6: result += "sixty"; break;
                case 7: result += "seventy"; break;
                case 8: result += "eighty"; break;
                case 9: result += "ninety"; break;
            }

          
            if (ones > 0)
            {
                result += " " + GetOnes(ones);
            }

            Console.WriteLine(result);
            return;
        }

        
        if (number < 1000)
        {
            int hundreds = number / 100;
            int remainder = number % 100;

            string result = GetOnes(hundreds) + " hundred";

           
            if (remainder > 0)
            {
                result += " and " + NumberToWords(remainder);
            }

            Console.WriteLine(result);
        }
    }

    
    static string GetOnes(int number)
    {
        switch (number)
        {
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            default: return "";
        }
    }

   
    static string NumberToWords(int number)
    {
        if (number < 10)
        {
            return GetOnes(number);
        }

        if (number < 20)
        {
            switch (number)
            {
                case 10: return "ten";
                case 11: return "eleven";
                case 12: return "twelve";
                case 13: return "thirteen";
                case 14: return "fourteen";
                case 15: return "fifteen";
                case 16: return "sixteen";
                case 17: return "seventeen";
                case 18: return "eighteen";
                case 19: return "nineteen";
                default: return "";
            }
        }

        int tens = number / 10;
        int ones = number % 10;
        string result = "";

        switch (tens)
        {
            case 2: result += "twenty"; break;
            case 3: result += "thirty"; break;
            case 4: result += "forty"; break;
            case 5: result += "fifty"; break;
            case 6: result += "sixty"; break;
            case 7: result += "seventy"; break;
            case 8: result += "eighty"; break;
            case 9: result += "ninety"; break;
        }

        if (ones > 0)
        {
            result += " " + GetOnes(ones);
        }

        return result;
    }
}

