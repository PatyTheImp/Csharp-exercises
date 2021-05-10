using System;

namespace PrimeiroExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            float w = 30.2f;
            string texto = "Hello world!";

            Console.WriteLine(w);

            ImprimeNome(texto);
        }

        public static void ImprimeNome(string nome)
        {
            Console.WriteLine("{0}", nome);
        }

        public static int SomaValores(int x, int y)
        {
            return x + y;
        }
    }
}
