namespace Number2String;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number (up to 3 digits): ");
        int num = int.Parse(Console.ReadLine());

        if (num < 0 || num > 999)
        {
            Console.WriteLine("Invalid input. Please enter a non-negative integer up to 3 digits.");
        }
        else if (num == 0)
        {
            Console.WriteLine("zero");
        }
        else
        {
            string words = "";

            int hundreds = num / 100;
            if (hundreds > 0)
            {
                words += Ones(hundreds) + " hundred";
                num %= 100;
                if (num > 0)
                {
                    words += " and ";
                }
            }


            if (num >= 20)
            {
                int tens = num / 10;
                words += Tens(tens);
                num %= 10;
                if (num > 0)
                {
                    words += " ";
                }
            }

            if (num >= 10)
            {
                words += Teens(num);
            }
            else if (num > 0)
            {
                words += Ones(num);
            }

            Console.WriteLine(words.Trim());
        }
        static string Ones(int num)
        {
            switch (num)
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

        static string Tens(int num)
        {
            switch (num)
            {
                case 2: return "twenty";
                case 3: return "thirty";
                case 4: return "forty";
                case 5: return "fifty";
                case 6: return "sixty";
                case 7: return "seventy";
                case 8: return "eighty";
                case 9: return "ninety";
                default: return "";
            }
        }

        static string Teens(int num)
        {
            switch (num)
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
    }
}