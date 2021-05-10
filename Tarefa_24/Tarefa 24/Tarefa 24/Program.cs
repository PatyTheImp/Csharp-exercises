using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAlunos_PRI_7
{
    class Program
    {
        /*
         * 
         * Adicionar aluno
           Remover aluno
           Consultar alunos
           Sair
         */

        static void Main(string[] args)
        {
            int pos = 0;
            string[] alunos = new string[100];
            string aluno;
            char op;

            do
            {
                Console.Clear();
                Menu();
                op = Console.ReadKey(true).KeyChar; //Tem o mesmo efeito que o getch() em C
                Console.Clear();

                switch (op)
                {
                    //Adicionar aluno
                    case '1':
                        Console.Write("Insira o nome do aluno a adicionar: ");
                        aluno = Console.ReadLine();
                        bool resultado = AdicionarAluno(alunos, pos, aluno);

                        if (resultado)
                        {
                            Console.WriteLine("Aluno inserido com sucesso.");
                            pos++;
                        }
                        else
                            Console.WriteLine("Não é possivel inserir o aluno.");
                        op = FimFuncionalidade();
                        break;

                    //Remover aluno
                    case '2':
                        Console.Write("Insira o nome do aluno a remover: ");
                        aluno = Console.ReadLine();

                        resultado = RemoverAluno(alunos, pos, aluno);

                        if (resultado)
                        {
                            Console.WriteLine("Aluno removido com sucesso.");
                            pos--;
                        }
                        else
                            Console.WriteLine("Não é possivel remover o aluno.");
                        op = FimFuncionalidade();
                        break;

                    //Consultar alunos
                    case '3':
                        if (pos > 0)
                            ConsularAlunos(alunos, pos);
                        else
                            Console.WriteLine("Não existem alunos inscritos.");
                        op = FimFuncionalidade();
                        break;

                    //Frequência de um nome
                    case '4':
                        Console.WriteLine("Insira o nome que quer consultar a frequência: ");
                        aluno = Console.ReadLine();
                        Console.WriteLine("Número de alunos com os mesmo nome: {0}", FrequenciaNome(alunos, pos, aluno));
                        break;
                    //Sair
                    case '0':
                        break;

                    //Opção inválida
                    default:
                        Console.Beep(); //Som para indicar erro 
                        break;
                }
            }
            while (op != '0');

            Console.WriteLine("\nFIM DO PROGRAMA");
        }

        public static void Menu()
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("Adcionar nome de aluno á lista..................(1)");
            Console.WriteLine("Remover nome do aluno da lista..................(2)");
            Console.WriteLine("Consultar lista de alunos.......................(3)");
            Console.WriteLine("Consultar frequência de um nome.................(4)");
            Console.WriteLine("Sair............................................(0)");
        }

        //Mostra mensagem no fim de cada funcionalidade 
        public static char FimFuncionalidade()
        {
            Console.WriteLine("Precione '0' para sair ou uma outra tecla qualquer para voltar ao menu.");
            return Console.ReadKey(true).KeyChar;
        }

        public static bool AdicionarAluno(string[] array_alunos, int posicao, string nome_aluno)
        {
            if(posicao >= array_alunos.Length || posicao < 0)
                return false;

            array_alunos[posicao] = nome_aluno;
            return true;
        }

        public static bool RemoverAluno(string[] array_alunos, int posicao, string nome_aluno)
        {
            for(int i = 0; i < posicao; i++)
            {
                if(array_alunos[i] == nome_aluno)
                {
                    for (int j = i; j < posicao-1; j++)
                    {
                        array_alunos[j] = array_alunos[j + 1];
                    }

                    array_alunos[posicao - 1] = null;
                    return true;
                }
            }

            return false;
        }

        public static void ConsularAlunos(string[] array_alunos, int posicao)
        {
            Console.WriteLine("ALUNOS INSCRITOS: ");
            for (int i = 0; i < posicao; i++)
            {
                Console.WriteLine("{0} - {1}", (i + 1), array_alunos[i]);
            }

        }

        public static int FrequenciaNome(string[] array_alunos, int posicao, string nome_aluno)
        {
            int freq = 0;

            for (int i = 0; i < posicao; i++)
            {
                if (array_alunos[i] == nome_aluno)
                    freq++;
            }

            return freq;
        }
    }
}
