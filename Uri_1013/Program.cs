using System;

namespace Uri_1013
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vs = Console.ReadLine().Split(' ');

            int a = int.Parse(vs[0]);
            int b = int.Parse(vs[1]);
            int c = int.Parse(vs[2]);

            int maior = ((a + b) + Math.Abs(a - b)) / 2;
            maior = ((maior + c) + Math.Abs(maior - c)) / 2;

            Console.WriteLine($"{maior} eh o maior");
        }
    }
}
