using System;

namespace Tarefa_22
{
    class Program
    {
        static void Main(string[] args)
        {
            //MÉTODO 1: 
            int[] array = new int[] { 40, 30, 80, 10, 50, 100, 20, 60, 90, 70 };
            int[] arrayProvisorio = new int[array.Length];

            //Vai arrumando os elementos do array no array provisório, do menor para o menor
            for (int i = 0; i < arrayProvisorio.Length; i++)
            {
                int indice = IndiceMin(array);
                arrayProvisorio[i] = array[indice];
                array[indice] = ValorMax(array) + 1; //Coloca um número grande na posição onde estava o valor mínimo do array
            }

            array = arrayProvisorio;

            Console.Write("[ ");
            for (int i = 0; i < array.Length; i++)
                Console.Write("{0} ", array[i]);
            Console.WriteLine("]");

            //MÉTODO 2:
            int[] array2 = new int[] { 40, 30, 80, 10, 50, 100, 20, 60, 90, 70 };
            int troca;
            
            for (int i = 0; i < array2.Length - 1; i++)
            {
                //Encontra o mínimo apartir de certo elemento e troca de posições
                for (int j = i + 1; j < array2.Length; j++)
                {
                    if (array2[i] > array2[j])
                    {
                        troca = array2[i];
                        array2[i] = array2[j];
                        array2[j] = troca;
                    }
                }                   
            }

            Console.Write("[ ");
            for (int i = 0; i < array2.Length; i++)
                Console.Write("{0} ", array2[i]);
            Console.WriteLine("]");
        }

        //Função que indica a posição onde está o menor elemento do array
        public static int IndiceMin(int[] paraArray)
        {
            int indice = 0;
            int min = paraArray[0];

            for (int i = 1; i < paraArray.Length; i++)
            {
                if (paraArray[i] < min)
                {
                    min = paraArray[i];
                    indice = i;
                }       
            }

            return indice;
        }

        public static int ValorMax(int[] paraArray)
        {

            int max = paraArray[0];

            for (int i = 1; i < paraArray.Length; i++)
            {
                if (paraArray[i] > max)
                {
                    max = paraArray[i];

                }
            }

            return max;
        }
    }
}
