using System;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double backwall = x * x;
            double frontwall = (x * x) - (1.2 * 2.00);
            double sidewalls = 2 * (x * y) - 2 * (1.50 * 1.50);
            double wallsSurface = backwall + frontwall + sidewalls;
            double green = wallsSurface / 3.40;
            Console.WriteLine(Math.Round(green, 2));

            double roofsides = 2 * (x * y);
            double triangleRoofsides = 2 * (x * h) / 2;
            double totallRoofSurface = roofsides + triangleRoofsides;
            double red = totallRoofSurface / 4.30;
            Console.WriteLine(Math.Round(red, 2));
        }
    }
}
