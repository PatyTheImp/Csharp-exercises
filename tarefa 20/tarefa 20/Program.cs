using System;

namespace tarefa_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano, anos, meses, dias;
            double distancia, Lpor100, preco;
            char op;

            do
            {
                Console.Clear();

                op = Menu();
                
                Console.Clear();

                switch (op)
                {
                    case '1':
                        Console.Write("Insira um ano: ");
                        ano = int.Parse(Console.ReadLine());
                        AnoBissexto(ano);
                        op = Sair();
                        break;

                    case '2':
                        Console.WriteLine("Insira uma idadade em anos, meses e dias.");
                        Console.Write("Anos: ");
                        anos = int.Parse(Console.ReadLine());
                        Console.Write("Meses: ");
                        meses = int.Parse(Console.ReadLine());
                        Console.Write("Dias: ");
                        dias = int.Parse(Console.ReadLine());

                        Console.WriteLine("Total de dias: {0}", IdadeDias(anos, meses, dias));
                        op = Sair();
                        break;

                    case '3':
                        Console.Write("Insira a distância em km: ");
                        distancia = double.Parse(Console.ReadLine());
                        Console.Write("Insira o consumo médio de combustivel em l/100: ");
                        Lpor100 = double.Parse(Console.ReadLine());
                        Console.Write("Insira o preço do litro do combuntivel: ");
                        preco = double.Parse(Console.ReadLine());

                        Console.WriteLine("Custo da viajem: {0} euros", Math.Round(CustoViajem(distancia, Lpor100, preco), 2));
                        op = Sair();
                        break;

                    case '0':
                        break;

                    default:
                        Console.Beep();
                        break;
                } 
            }
            while (op != '0');

            Console.WriteLine("\nAdeus!");
        }

        public static char Menu()
        {
            Console.WriteLine("Verificar se um ano é bissexto\t(1)");
            Console.WriteLine("Idade em dias\t\t\t(2)");
            Console.WriteLine("Custo de uma viajem\t\t(3)");
            Console.WriteLine("\nSair\t\t\t\t(0)\n");
            Console.Write("->");

            return Console.ReadKey(true).KeyChar; //mesmo efeito que o getch() em C
        }

        public static void AnoBissexto(int year)
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                Console.WriteLine("{0} é bissexto!", year);
            else
                Console.WriteLine("{0} não é bissexto!", year);
        }

        public static int IdadeDias(int years, int months, int days)
        {
            return years * 365 + months * 30 + days;
        }

        public static double CustoViajem(double distance, double Lper100, double price)
        {
            return (distance * Lper100 / 100) * price;
        }

        public static char Sair()
        {
            Console.WriteLine("\nPrima '0' para sair ou uma tecla qualquer para voltar ao menu");
            return Console.ReadKey(true).KeyChar; //mesmo efeito que o getch() em C
        }
    }
}
