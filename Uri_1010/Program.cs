using System;
using System.Globalization;

namespace Uri_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vs;
            int codigo, qtPecas;
            double vlrUnitario, vlrAPagar = 0;
            
            for (int i = 0; i < 2; i++)
            {
                vs = Console.ReadLine().Split(' ');
                codigo = int.Parse(vs[0]);
                qtPecas = int.Parse(vs[1]);
                vlrUnitario = double.Parse(vs[2], CultureInfo.InvariantCulture);

                vlrAPagar += qtPecas * vlrUnitario;
            }

            Console.WriteLine($"VALOR A PAGAR: R$ {vlrAPagar.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
