using System;

namespace NumberPrettifier
{
    public class NumberPrettifier
    {
        static void Main(string[] args)
        {
            bool continueRunning = true;

            while (continueRunning)
            {
                Console.WriteLine("Enter a number:");
                if (double.TryParse(Console.ReadLine(), out double number))
                {
                    string prettified = PrettifyNumber(number);
                    Console.WriteLine($"Prettified number: {prettified}");
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }

                Console.WriteLine("Do you want to enter another number? (yes/no):");
                string response = Console.ReadLine().Trim().ToLower();
                if (response != "yes")
                {
                    continueRunning = false;
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static string PrettifyNumber(double number)
        {
            bool isNegative = number < 0;
            number = Math.Abs(number);

            const double trillion = 1_000_000_000_000;
            const double billion = 1_000_000_000;
            const double million = 1_000_000;

            string result;

            if (number >= trillion)
            {
                result = (number / trillion).ToString("0.#") + "T";
            }
            else if (number >= billion)
            {
                double billions = number / billion;
                result = billions >= 999.95 ? "1T" : billions.ToString("0.#") + "B";
            }
            else if (number >= million)
            {
                double millions = number / million;
                result = millions >= 999.95 ? "1B" : millions.ToString("0.#") + "M";
            }
            else
            {
                result = number.ToString();
            }

            return isNegative ? "-" + result : result;
        }


    }
}
