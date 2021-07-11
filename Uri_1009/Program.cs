using System.Globalization;
using System;

namespace Uri_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double totalReceber = (totalVendas * 15 / 100) + salario;

            Console.WriteLine($"TOTAL = R$ {totalReceber.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
