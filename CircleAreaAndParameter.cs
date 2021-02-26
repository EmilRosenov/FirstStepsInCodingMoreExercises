using System;

namespace CircleAreaAndParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            double parameter = 2 * Math.PI * r;

            Console.WriteLine(Math.Round(area, 2));
            Console.WriteLine(Math.Round(parameter, 2));
        }
    }
}
