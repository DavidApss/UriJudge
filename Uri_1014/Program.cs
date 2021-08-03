using System;
using System.Globalization;

namespace Uri_1014
{
    class Program
    {

        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double consumoMedio = x / y;

            Console.WriteLine($"{consumoMedio.ToString("F3", CultureInfo.InvariantCulture)} km/l");
        }
    }
}
