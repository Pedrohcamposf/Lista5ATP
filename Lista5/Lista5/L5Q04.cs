using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasATP
{
    public static class L5Q04
    {
        public static void Executar()
        {
            {
                int a = 10, b = 10;
                Matriz(a, b);

            }
            static void Matriz(int x, int y)
            {
                int[,] m = new int[x, y];
                int i = 0, j = 0;

                while (i < x)
                {
                    while (j < y)
                    {
                        m[i, j] = i + j;
                        j++;
                    }
                    i++;
                    Console.WriteLine();
                }

                NovoVetor(m);
            }

            static void NovoVetor(int[,] ma)
            {
                int x = ma.GetLength(0);
                int y = ma.GetLength(1);
                int[,] nv = new int[x, y];

                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        if ((i + j) % 2 != 0)
                        {
                            nv[i, j] = i + 1;
                        }
                        else
                        {
                            nv[i, j] = j + 1;
                        }
                    }
                }
                ExibirVetor(nv);
            }

            static void ExibirVetor(int[,] exibe)
            {
                int x = exibe.GetLength(0);
                int y = exibe.GetLength(1);

                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        Console.Write(exibe[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}