using System;

namespace NumberPrettifier
{
    public class NumberPrettifier
    {
        static void Main(string[] args)
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
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static string PrettifyNumber(double number)
        {
            if (number >= 1_000_000_000_000)
                return (number / 1_000_000_000_000).ToString("0.#") + "T";
            else if (number >= 1_000_000_000)
                return (number / 1_000_000_000).ToString("0.#") + "B";
            else if (number >= 1_000_000)
                return (number / 1_000_000).ToString("0.#") + "M";
            else
                return number.ToString();
        }
    }
}
