using System;

namespace Tarefa_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int expoente, i, dec;
            double base_, resultado;

            Console.WriteLine("CALCULAR A POTÊNCIA:");

            Console.Write("Introduza uma base: ");
            base_ = double.Parse(Console.ReadLine());

            Console.Write("Introduza um expoente: ");
            expoente = int.Parse(Console.ReadLine());

            if (expoente < 0)
            {
                expoente = -1 * expoente;
                resultado = Potencia(base_, expoente);
                resultado = 1 / resultado;
            }
            else
                resultado = Potencia(base_, expoente);

            Console.WriteLine("Resultado = {0}", resultado);

            Console.WriteLine("\nSEQUÊNCIA DE FIBONACCI:");

            Console.Write("Insira um termo da sequência de fibonacci: ");
            i = int.Parse(Console.ReadLine());

            Console.WriteLine("F({0}) = {1}", i, Fibonacci(i));

            Console.WriteLine("BINÁRIOS:");

            Console.Write("Insira um número inteiro positivo de base 10: ");
            dec = int.Parse(Console.ReadLine());

            Console.WriteLine("Binário = {0}", Binario(dec));
            Console.Write("Binário = ");
            ProcBin(dec);
        }

        public static double Potencia(double base_, int expoente)
        {
            if (expoente == 0)
                return 1;

            if (expoente == 1)
                return base_;

            return base_ * Potencia(base_, expoente - 1);
        }

        public static int Fibonacci(int i)
        {
            if (i == 0 || i == 1)
                return i;

            return Fibonacci(i - 2) + Fibonacci(i - 1);
        }

        public static long Binario(int dec)
        {
            if (dec == 0)
                return  0;

            return  Binario(dec / 2) * 10 + (dec % 2);
        }

        //Versão dos binários em forma de procedimento
        public static void ProcBin(int dec)
        {
            if (dec == 0)
                return;

            ProcBin(dec / 2);
            Console.Write(dec % 2);
        }
    }
}
