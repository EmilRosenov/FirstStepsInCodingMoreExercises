using System;

namespace WetherForecastPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());


            if (celsius <= 5.00)
            {
                Console.WriteLine("unknown");
            }

            else if (celsius > 5.00 && celsius <= 11.90)
            {
                Console.WriteLine("Cold");
            }

            else if (celsius >= 12.00 && celsius <= 14.90)
            {
                Console.WriteLine("Cool");
            }

            else if (celsius >= 15.00 && celsius <= 20.00)
            {
                Console.WriteLine("Mild");
            }

            else if (celsius >= 20.10 && celsius <= 25.90)
            {
                Console.WriteLine("Warm");
            }

            else if (celsius >= 26.00 && celsius <= 35.00)
            {
                Console.WriteLine("Hot");
            }

        }
    }
}
