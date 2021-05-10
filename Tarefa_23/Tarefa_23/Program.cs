using System;

namespace Tarefa_23
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alunos = new string[100];
            string nomeAluno;
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
                        Console.Write("Insira o nome do aluno que quer adcionar: ");
                        nomeAluno = Console.ReadLine();
                        alunos = AdcionarAluno(alunos, nomeAluno);
                        Console.WriteLine("Nome adcionado com sucesso!");
                        op = FimFuncionalidade();
                        break;

                    //Remover aluno
                    case '2':
                        Console.Write("Insira o nome do aluno que quer remover: ");
                        nomeAluno = Console.ReadLine();
                        alunos = RemoverAluno(alunos, nomeAluno);                        
                        op = FimFuncionalidade();
                        break;

                    //Consultar alunos
                    case '3':
                        ConsultarAlunos(alunos);
                        op = FimFuncionalidade();
                        break;

                    //Ordenar alunos 
                    case '4':
                        OrganizaArray(alunos);
                        Console.WriteLine("Lista ordenada com sucesso!");
                        op = FimFuncionalidade();
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
            Console.WriteLine("Ordenar a lista de alunos em ordem alfabética...(4)");
            Console.WriteLine("Sair............................................(0)");
        }

        //Acrecenta o nome do aluno ao array 
        public static string[] AdcionarAluno(string[] paraAlunos, string paraAluno)
        {
            int i = 0;

            //Percorre o array até encontrar o elemento null
            while (paraAlunos[i] != null)
                i++;

            //Substitui o primeiro elemento null pelo nome do aluno
            paraAlunos[i] = paraAluno;

            //Retorna o array atualizado
            return paraAlunos;
        }

        //Mostra a lista de alunos (por ordem de adição ou alfabética, dependendo do que se põe no segundo parametro)
        public static void ConsultarAlunos(string[] paraAlunos)
        {
            //Se o primeiro elemento do array for null, então a lista está vazia
            if (paraAlunos[0] == null)
                Console.WriteLine("A lista está vazia!");
            else
            {
                Console.WriteLine("Lista de alunos:");
                for (int i = 0; paraAlunos[i] != null; i++)
                    Console.WriteLine(paraAlunos[i]);
            }       
        }

        //Mostra mensagem no fim de cada funcionalidade 
        public static char FimFuncionalidade()
        {
            Console.WriteLine("Precione '0' para sair ou uma outra tecla qualquer para voltar ao menu.");
            return Console.ReadKey(true).KeyChar;
        }

        //Não foi pedido na tarefa mas eu quis fazer :D
        //Ordena o array por ordem alfabética
        public static string[] OrganizaArray(string[] paraAlunos)
        {
            int cont;
            string troca;

            do
            {
                cont = 0;

                for (int i = 0, j = 1; paraAlunos[j] != null; i++, j++)
                {
                    //O método CompareTo retorna um inteiro positivo se a primeira string suceder a segunda, nesse caso faz-se a troca 
                    if (paraAlunos[i].CompareTo(paraAlunos[j]) > 0)
                    {
                        troca = paraAlunos[i];
                        paraAlunos[i] = paraAlunos[j];
                        paraAlunos[j] = troca;

                        cont++;
                    }
                }
            }
            while (cont != 0);

            return paraAlunos;
        }

        public static string[] RemoverAluno(string[] paraAlunos, string paraNome)
        {
            int i = 0;

            //Percorre o array até encontrar o nome correspondente, se não encontrar para quando encontrar um elemento null
            while (paraAlunos[i] != paraNome && paraAlunos[i] != null)
                i++;

            if (paraAlunos[i] == null)
                Console.WriteLine("Nome não encontrado.");
            else
            {
                //Contando apartir da posição onde foi encontrado o nome procurado, substitui-se o 
                //elemento de cada posição com o elemento da posição seguinte (contando com o primeiro null)
                for (int j = i; paraAlunos[j] != null; j++)
                    paraAlunos[j] = paraAlunos[j + 1];

                Console.WriteLine("Nome removido com sucesso!");
            }

            return paraAlunos;
        }
    }

    
}
