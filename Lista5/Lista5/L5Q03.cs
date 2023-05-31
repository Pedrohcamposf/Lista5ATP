using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasATP
{
    public static class L5Q03
    {
        public static void Executar()
        {
            int[] x = new int[10];
            CriarVetor(x);

            int[] y = CriarNegativo(x);

            ExibirVetor(x , "Vetor X:");
            ExibirVetor(y , "Vetor de Negativos:");

            Console.ReadLine();

            static void CriarVetor(int[] notas)
            {
                Random rd = new Random();
                for (int i = 0; i < notas.Length; i++)
                {
                    notas[i] = rd.Next(-1000,1000);
                }
            }
            static int[] CriarNegativo(int[] vetor)
            {
                int[] vetorNegativos = new int[vetor.Length];
                int indice = 0;

                for (int i = 0; i < vetor.Length; i++)
                {
                    if (vetor[i] < 0)
                    {
                        vetorNegativos[indice] = vetor[i];
                        indice++;
                    }
                }

                // Criar um novo vetor com o tamanho exato dos elementos negativos
                int[] resultado = new int[indice];
                Array.Copy(vetorNegativos, resultado, indice);

                return resultado;
            }
            static void ExibirVetor(int[] vetor, string mensagem)
            {
                Console.WriteLine(mensagem);

                for (int i = 0; i < vetor.Length; i++)
                {
                    Console.Write(vetor[i] + " ");
                }

                Console.WriteLine();
            }

        }
    }
}
