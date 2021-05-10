using System;
using System.Threading;

namespace Tarefa_25
{
    class Program
    {
        static void Main(string[] args)
        {
            char op;
            int dim;

            do
            {
                Console.Clear();
                Titulo();
                Console.WriteLine("Insira a dimensão do tabuleiro: ");
                dim = int.Parse(Console.ReadLine());
                int[,] matriz = new int[dim, dim];

                ControlaJogo(matriz);

                Console.WriteLine("Jogar novamente? (Prima 's' se sim ou outra tecla qualquer se não)");
                Console.ResetColor();
                op = Console.ReadKey(true).KeyChar; //Efeito semelhante ao getch() em C;
            }
            while (op == 's' || op == 'S');

            Console.Clear();
            Adeus();
        }

        //Imprime uma matriz
        public static void ImprimeGrelha(int[,] mat)
        {                     
            int nrAlg, contador = 1, dim = mat.GetLength(0);            
            
            for (int i = 0; i < dim; i++)
            {
                Console.Write("\t\t\t");
                for (int j = 0; j < dim; j++)
                {
                    //Se a matriz tiver zero na posição o tabuleiro fica com o contador correspondente
                    if (mat[i, j] == 0)
                    {
                        nrAlg = NrDeAlgarismos(contador);

                        if (nrAlg == 1)
                            Console.Write(" {0} ", contador);
                        else if (nrAlg == 2)
                            Console.Write(" {0}", contador);
                        else
                            Console.Write("{0}", contador);
                    }
                    //Imprime um X caso o número da posição seja 1
                    else if (mat[i, j] == 1)
                        Console.Write(" X ");
                    //Imprime um O caso o número da posição seja 2
                    else if (mat[i, j] == 2)
                        Console.Write(" O ");
                    //Imprime um X verde caso o número da posição seja 3
                    else if (mat[i, j] == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green; //Muda a cor do texte para verde
                        Console.Write(" X ");
                        Console.ResetColor(); //Restaura a cor original do texto
                    }
                    //Imprime um O verde caso o número da posição seja 4
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" O ");
                        Console.ResetColor();
                    }

                    if (j < dim - 1) //Para imprimir o separador lateral
                        Console.Write("|");

                    contador++;
                }
                Console.WriteLine();
                //Imprime o separador inferior
                if (i != dim - 1) 
                {
                    Console.Write("\t\t\t");
                    for (int k = 0; k < dim; k++)
                    {
                        Console.Write("---");
                        if (k < dim - 1)
                            Console.Write("+");
                    }
                    Console.WriteLine();
                }
            }          
        }

        //Verifica se uma posição esta dentro da matriz
        public static bool ExistePosicao(int linha, int coluna, int[,] mat)
        {
            return (linha < mat.GetLength(0) && coluna < mat.GetLength(1) && linha >= 0 && coluna >= 0);
        }

        //Verifica se uma posição da matriz está vazia (igual a 0)
        public static bool EstaVazio(int linha, int coluna, int[,] mat)
        {
            return (mat[linha, coluna] == 0);
        }

        //Adiciona um valor inteiro a uma posição da matriz
        public static void AdicionaNaPosicao(int linha, int coluna, int valor, int[,] mat)
        {
            mat[linha, coluna] = valor;
        }

        //Retorna o número relativo à linha de um determinado indice. 
        //O indice é o contador que aparece na grelha sempre que a posição está vazia
        public static int IndiceLinha(int[,] mat, int indice)
        {
            int dim = mat.GetLength(0);

            if (indice <= 0)
                return -1;

            return (indice - 1) / dim;
        }

        //Retorna o número relativo à coluna de um determinado indice.
        //O indice é o contador que aparece na grelha sempre que a posição está vazia
        public static int IndiceColuna(int[,] mat, int indice)
        {
            int dim = mat.GetLength(1);

            return (indice + (dim - 1)) % dim;
        }

        //Devolve uma linha da matriz num array unidimensional
        public static int[] LinhaMatriz(int linha, int[,] mat)
        {
            int[] linhaMat = new int[mat.GetLength(0)];

            for (int i = 0; i < mat.GetLength(0); i++)
                linhaMat[i] = mat[linha, i];

            return linhaMat;
        }

        //Devolve uma coluna da matriz num array unidimensional
        public static int[] ColunaMatriz(int coluna, int[,] mat)
        {
            int[] colunaMat = new int[mat.GetLength(1)];

            for (int i = 0; i < mat.GetLength(1); i++)
                colunaMat[i] = mat[i, coluna];

            return colunaMat;
        }

        //Devolve a diagonal esquerda da matriz num array unidimensional
        public static int[] DiagonalEsquerdaMatriz(int[,] mat)
        {
            int[] diagEsq = new int[mat.GetLength(0)];

            for (int i = 0, j = 0; i < mat.GetLength(0); i++, j++)
                diagEsq[i] = mat[i, j];

            return diagEsq;
        }

        //Devolve a diagonal direita da matriz num array unidimensional
        public static int[] DiagonalDireitaMatriz(int[,] mat)
        {
            int dim = mat.GetLength(0);
            int[] diagDrt = new int[dim];

            for (int i = 0, j = (dim - 1); i < dim; i++, j--)
                diagDrt[i] = mat[i, j];

            return diagDrt;
        }

        //Altera uma linha da matriz somando 2 a todas as posições
        public static void GanhaLinhaMatriz(int linha, int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
                mat[linha, i] += 2;
        }

        //Altera uma coluna da matriz somando 2 a todas as posições
        public static void GanhaColunaMatriz(int coluna, int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(1); i++)
                mat[i, coluna] += 2;
        }

        //Altera diagonal esquerda da matriz somando 2 a todas as posições
        public static void GanhaDiagonalEsquerda(int[,] mat)
        {
            for (int i = 0, j = 0; i < mat.GetLength(0); i++, j++)
                mat[i, j] += 2;
        }

        //Altera diagonal direita da matriz somando 2 a todas as posições
        public static void GanhaDiagonalDireita(int[,] mat)
        {
            for (int i = 0, j = (mat.GetLength(0) - 1); i < mat.GetLength(0); i++, j--)
                mat[i, j] += 2;
        }

        //Verifica se um array unidimensional tem todos os seus valores iguais, caso sejam 0 assume que são valores diferentes
        public static bool ValoresIguais(int[] tab)
        {
            for (int i = 1; i < tab.Length; i++)
            {
                //Sai do ciclo se dois elementos seguidos do array forem diferentes ou se um for igual a 0
                if (tab[i - 1] != tab[i] || tab[i - 1] == 0) 
                    return false;
            }

            return true;
        }

        //Verifica se todas as linhas, colunas ou diagonais têm os seus valores iguais.
        //Caso encontre uma resposta verdadeira deve invocar a função “Ganha” correspondente.
        public static bool MatrizIguais(int[,] mat)
        {
            int dim = mat.GetLength(0);

            //Verifica a diagonal esquerda 
            if (ValoresIguais(DiagonalEsquerdaMatriz(mat)))
            {
                GanhaDiagonalEsquerda(mat);
                return true;
            }

            //Verifica a diagonal direita 
            if (ValoresIguais(DiagonalDireitaMatriz(mat)))
            {
                GanhaDiagonalDireita(mat);
                return true;
            }

            //Verifica as linhas
            for (int i = 0; i < dim; i++)
            {
                if (ValoresIguais(LinhaMatriz(i, mat)))
                {
                    GanhaLinhaMatriz(i, mat);
                    return true;
                }
            }

            //Verifica as colunas
            for (int i = 0; i < dim; i++)
            {
                if (ValoresIguais(ColunaMatriz(i, mat)))
                {
                    GanhaColunaMatriz(i, mat);
                    return true;
                }
            }

            return false;
        }

        public static void ControlaJogo(int[,] mat)
        {
            string[] nomes = new string[2];
                                                     //Contador do nº de jogadas   
            int pos, linha, coluna, jogadorAtual = 1, jogadaNr = 1;
            bool naoExistePosicao, vitoria; 

            Console.Write("Insira o nome do jogador 1: ");
            nomes[0] = Console.ReadLine();
            Console.Write("Insira o nome do jogador 2: ");
            nomes[1] = Console.ReadLine();

            while(true)
            {
                do
                {
                    Console.Clear();
                    Titulo();
                    ImprimeGrelha(mat);

                    //Imprime o nome do jogador cujo o indice no array nomes é igual ao nº do jogador menos 1
                    Console.WriteLine("\n\nÉ a vez do/a {0}!", nomes[jogadorAtual - 1]);
                    Console.WriteLine("Escolha a posição em que quer jogar: ");
                    pos = int.Parse(Console.ReadLine());

                    linha = IndiceLinha(mat, pos);
                    coluna = IndiceColuna(mat, pos);                   

                    if (naoExistePosicao = !ExistePosicao(linha, coluna, mat))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Essa posição não existe!\a");
                        Console.ResetColor();
                        Thread.Sleep(2000); //Espera 2 segundos
                    }
                    else if (!EstaVazio(linha, coluna, mat))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Essa posição já está ocupada!\a");
                        Console.ResetColor();
                        Thread.Sleep(2000); //Espera 2 segundos
                    }
                }
                while (naoExistePosicao || !EstaVazio(linha, coluna, mat));
                AdicionaNaPosicao(linha, coluna, jogadorAtual, mat);

                //Verifica se o jogo acabou apenas quando o número de jogadas é igual ou superior á dimensão do tabuleiro
                //ou seja, quando atinge o número mínimo de jogadas para uma vitória ser possível
                if (jogadaNr >= mat.GetLength(0))
                {
                    vitoria = MatrizIguais(mat);

                    if (vitoria || VerificaEmpate(mat))
                        break;
                }

                //Muda o jogador
                jogadorAtual = (jogadorAtual % 2) + 1;

                jogadaNr++; 
            }

            Console.Clear();
            Titulo();
            ImprimeGrelha(mat);
            Musiquinha();
            if (vitoria)
            {
                Vitoria(nomes[jogadorAtual - 1], jogadaNr);
                return;
            }
            Console.WriteLine("\n\nEmpate :(");
        }

        //Função extra. Deteta um empate antes do tabuleiro estar totalmente preenchido
        public static bool VerificaEmpate(int[,] mat)
        {
            int nrUm = 0, nrDois = 0, impedida = 0;
            int dim = mat.GetLength(0);

            //Verifica a diagonal direita
            foreach (int nr in DiagonalDireitaMatriz(mat))
            {
                //Contabiliza quantos 1 e 2 existem na diagonal
                if (nr == 1)
                    nrUm++;
                else if (nr == 2)
                    nrDois++;

                //Se houver pelo menos um 1 e um 2 na diagonal, essa diagonal está impedida de vitória
                if (nrUm >= 1 && nrDois >= 1)
                {
                    impedida++;
                    //Reset no número de 1 e 2 para poderem ser reutilizados
                    nrUm = 0;
                    nrDois = 0;
                    break;
                }
            }
            //Verifica a diagonal esquerda
            foreach (int nr in DiagonalEsquerdaMatriz(mat))
            {
                if (nr == 1)
                    nrUm++;
                else if (nr == 2)
                    nrDois++;

                if (nrUm >= 1 && nrDois >= 1)
                {
                    impedida++;
                    nrUm = 0;
                    nrDois = 0;
                    break;
                }
            }
            //Verifica as linhas
            for (int i = 0; i < dim; i++)
            {
                foreach (int nr in LinhaMatriz(i, mat))
                {
                    if (nr == 1)
                        nrUm++;
                    else if (nr == 2)
                        nrDois++;

                    if (nrUm >= 1 && nrDois >= 1)
                    {
                        impedida++;
                        nrUm = 0;
                        nrDois = 0;
                        break;
                    }
                }
            }
            //Verifica as colunas
            for (int i = 0; i < dim; i++)
            {
                foreach (int nr in ColunaMatriz(i, mat))
                {
                    if (nr == 1)
                        nrUm++;
                    else if (nr == 2)
                        nrDois++;

                    if (nrUm >= 1 && nrDois >= 1)
                    {
                        impedida++;
                        nrUm = 0;
                        nrDois = 0;
                        break;
                    }
                }
            }
            //Se o número de vitórias impedidas for igual ao total de diagonais, linhas e colunas então o empate é garantido
            return (impedida == (2 * dim + 2));
        }

        //Devolve o número de algarismos em um número (útil para imprimir o tabuleiro)
        public static int NrDeAlgarismos(int nr)
        {
            int algorismos = 1;

            for (int x = 10; x <= nr; x *= 10)
                algorismos++;

            return algorismos;
        }

        /***BONECADAS***/

        public static void Titulo()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("       __                         __         ______      __    ");
            Console.WriteLine("      / /___  ____ _____     ____/ /___     / ____/___ _/ /___ ");
            Console.WriteLine(" __  / / __ \\/ __ `/ __ \\   / __  / __ \\   / / __/ __ `/ / __ \\");
            Console.WriteLine("/ /_/ / /_/ / /_/ / /_/ /  / /_/ / /_/ /  / /_/ / /_/ / / /_/ /");
            Console.WriteLine("\\____/\\____/\\__, /\\____/   \\__,_/\\____/   \\____/\\__,_/_/\\____/ ");
            Console.Write("           /____/                        ");
            Console.ResetColor();
            Console.WriteLine("  Por Patrícia Costa\n\n");           
        }

        public static void Adeus()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" ____  ___  _   _    __    __  __ ");
            Console.WriteLine("(_  _)/ __)( )_( )  /__\\  (  )(  )");
            Console.WriteLine("  )( ( (__  ) _ (  /(__)\\  )(__)( ");
            Console.WriteLine(" (__) \\___)(_) (_)(__)(__)(______)");
            Console.ResetColor();
            Thread.Sleep(2000);
        }

        public static void Musiquinha()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Beep(523, 500); 
            }
            Console.Beep(523, 800);
            Thread.Sleep(2000);
        }

        public static void Vitoria(string vencedor, int jogadas)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Clear();

                Console.WriteLine("                                        __                                     ");
                Console.WriteLine("                                       /  |                                    ");
                Console.WriteLine("  ______    ______    ______   ______  $$ |____    ______   _______    _______ ");
                Console.WriteLine(" /      \\  /      \\  /      \\ /      \\ $$      \\  /      \\ /       \\  /       |");
                Console.WriteLine("/$$$$$$  | $$$$$$  |/$$$$$$  |$$$$$$  |$$$$$$$  |/$$$$$$  |$$$$$$$  |/$$$$$$$/ ");
                Console.WriteLine("$$ |  $$ | /    $$ |$$ |  $$/ /    $$ |$$ |  $$ |$$    $$ |$$ |  $$ |$$      \\ ");
                Console.WriteLine("$$ |__$$ |/$$$$$$$ |$$ |     /$$$$$$$ |$$ |__$$ |$$$$$$$$/ $$ |  $$ | $$$$$$  |");
                Console.WriteLine("$$    $$/ $$    $$ |$$ |     $$    $$ |$$    $$/ $$       |$$ |  $$ |/     $$/ ");
                Console.WriteLine("$$$$$$$/   $$$$$$$/ $$/       $$$$$$$/ $$$$$$$/   $$$$$$$/ $$/   $$/ $$$$$$$/  ");
                Console.WriteLine("$$ |                                                                           ");
                Console.WriteLine("$$ |                                                                           ");
                Console.WriteLine("$$/                                                                            ");
                Console.WriteLine("\n\n{0} ganhou em {1} jogadas!", vencedor, jogadas);

                Thread.Sleep(1000);
                Console.Clear();

                Console.WriteLine("                                        __                                     ");
                Console.WriteLine("                                       |  \\                                    ");
                Console.WriteLine("  ______    ______    ______   ______  | $$____    ______   _______    _______ ");
                Console.WriteLine(" /      \\  |      \\  /      \\ |      \\ | $$    \\  /      \\ |       \\  /       \\");
                Console.WriteLine("|  $$$$$$\\  \\$$$$$$\\|  $$$$$$\\ \\$$$$$$\\| $$$$$$$\\|  $$$$$$\\| $$$$$$$\\|  $$$$$$$");
                Console.WriteLine("| $$  | $$ /      $$| $$   \\$$/      $$| $$  | $$| $$    $$| $$  | $$ \\$$    \\ ");
                Console.WriteLine("| $$__/ $$|  $$$$$$$| $$     |  $$$$$$$| $$__/ $$| $$$$$$$$| $$  | $$ _\\$$$$$$\\");
                Console.WriteLine("| $$    $$ \\$$    $$| $$      \\$$    $$| $$    $$ \\$$     \\| $$  | $$|       $$");
                Console.WriteLine("| $$$$$$$   \\$$$$$$$ \\$$       \\$$$$$$$ \\$$$$$$$   \\$$$$$$$ \\$$   \\$$ \\$$$$$$$ ");
                Console.WriteLine("| $$                                                                           ");
                Console.WriteLine("| $$                                                                           ");
                Console.WriteLine(" \\$$                                                                           ");
                Console.WriteLine("\n\n{0} ganhou em {1} jogadas!", vencedor, jogadas);
                Thread.Sleep(1000);
            }
        }
    }
}
