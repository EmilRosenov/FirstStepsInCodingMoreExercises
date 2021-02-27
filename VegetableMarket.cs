using System;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegPriceKg = double.Parse(Console.ReadLine());
            double fruitPriceKg = double.Parse(Console.ReadLine());
            double totalKgVeg = double.Parse(Console.ReadLine());
            double totalKgFruit = double.Parse(Console.ReadLine());

            double totalPriceVeg = vegPriceKg * totalKgVeg;
            double totalPriceFruit = fruitPriceKg * totalKgFruit;
            double totalMoney = totalPriceFruit + totalPriceVeg;
            double priceInEuro = totalMoney / 1.94;

            Console.WriteLine($"{priceInEuro:f2}");
        }
    }
}
