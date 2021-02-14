using System;

namespace Uri_1007
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, diferenca;

            Console.WriteLine();
            Console.Write("Digite o primeiro número : ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Digite o Segundo número : ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Digite o Terceiro número : ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Digite o Quarto número : ");
            d = int.Parse(Console.ReadLine());

            diferenca = (a * b) - (c * d);

            Console.WriteLine();
            Console.Write("Diferença = " +diferenca);
        }
    }
}
