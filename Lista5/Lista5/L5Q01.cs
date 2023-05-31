using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ListasATP
{
    public static class L5Q01
    {
        public static void Executar()
        {
            {
                int[] n = new int[20];
                Random random = new Random();

                // Preenchendo o vetor N com números aleatórios
                for (int i = 0; i < 20; i++)
                {
                    n[i] = random.Next(100); // Gera um número aleatório entre 0 e 99
                }
                int m = n[0]; //Criando variavel com a primeira posição para fazer as comparações
                int p = 0;
                // Encontrando o menor elemento e sua posição usando a comparação//
                for (int i = 1; i < 20; i++)
                {
                    if (n[i] < m)
                    {
                        m = n[i];
                        p = i;
                    }
                }
                Console.WriteLine("O vetor gerado é:");
                for (int i = 0; i < 20; i++)
                {
                    Console.Write(n[i] + " ");
                }
                Console.WriteLine("\n\nO menor elemento de N é {0} e sua posição dentro do vetor é {1}.", m, p);
            }
        }
    }
}
