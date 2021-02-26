using System;

namespace FishLannd
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackerelPriceKg = double.Parse(Console.ReadLine());
            double toyPriceKg = double.Parse(Console.ReadLine());
            double bonitoKg = double.Parse(Console.ReadLine());
            double horsemackerelKg = double.Parse(Console.ReadLine());
            int musselKg = int.Parse(Console.ReadLine());

            double bonitoPriceKg = 1.6 * mackerelPriceKg;
            double horsemackerelPriceKg = 1.8 * toyPriceKg;
            double musselPriceKg = 7.50;
            double musselTotal = musselKg * musselPriceKg;
            double horsemackerelTotal = horsemackerelKg * horsemackerelPriceKg;
            double bonitoTotal = bonitoKg * bonitoPriceKg;
            double totalCost = musselTotal + horsemackerelTotal + bonitoTotal;
            Console.WriteLine(Math.Round(totalCost, 2));

        }
    }
}
