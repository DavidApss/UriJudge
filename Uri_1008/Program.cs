using System.Globalization;
using System;

namespace Uri_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigoFuncionario = int.Parse(Console.ReadLine());
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horasTrabalhadas * valorPorHora;

            Console.WriteLine($"NUMBER = {codigoFuncionario}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
