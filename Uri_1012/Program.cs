using System.Globalization;
using System;

namespace Uri_1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            string[] vs = Console.ReadLine().Split(' ');

            double a = double.Parse(vs[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vs[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vs[2], CultureInfo.InvariantCulture);

            double areaTriangulo = a * c / 2;
            double areaCirculo = pi * Math.Pow(c, 2);
            double areaTrapezio = (a + b) * c / 2;
            double areaQuadrado = Math.Pow(b, 2);
            double areaRetangulo = a * b;

            Console.WriteLine($"TRIANGULO: {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
