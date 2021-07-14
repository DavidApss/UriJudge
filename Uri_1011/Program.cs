using System.Globalization;
using System;

namespace Uri_1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double volume = (4.0 / 3 * 3.14159) * Math.Pow(r, 3);

            Console.WriteLine($"VOLUME = {volume.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
