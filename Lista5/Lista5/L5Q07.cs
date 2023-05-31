using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasATP
{
    public static class L5Q07
    {
        public static void Executar()
        {
            int[,] Matriz = new int[5, 5];
            PreencherMatriz(Matriz);

            int RespostaA = FuncaoA(Matriz, 4);
            int RespostaB = FuncaoB(Matriz, 2);
            int RespostaC = FuncaoC(Matriz);
            int RespostaD = FuncaoD(Matriz);
            int RespostaE = FuncaoE(Matriz);

            Console.WriteLine("A soma do valor de cada da linha 4 da matriz é: " + RespostaA + "\nA soma do valor de cada da coluna 2 da matriz é: " + RespostaB +
                "\nA soma do valor de cada posição da diagonal primaria é: " + RespostaC + "\nA soma do valor de cada posição diagonal secundária é: " + RespostaD +
                "\nA soma do valor de todas as posições da matriz é: " + RespostaE);

            static void PreencherMatriz(int[,] MatrizBase)
            {
                Random r = new Random();
                for (int i = 0; i < MatrizBase.GetLength(0); i++)
                {
                    for (int j = 0; j < MatrizBase.GetLength(1); j++)
                    {
                        MatrizBase[i, j] = r.Next(0, 10);
                    }
                }
            }

            static int FuncaoA(int[,] CalculoMatriz, int linha)
            {
                int SomaA = 0;
                for (int i = 0; i < CalculoMatriz.GetLength(1); i++)
                {
                    SomaA += CalculoMatriz[linha, i];
                }
                return SomaA;
            }

            static int FuncaoB(int[,] CalculoMatriz, int coluna)
            {
                int SomaB = 0;
                for (int i = 0; i < CalculoMatriz.GetLength(0); i++)
                {
                    SomaB += CalculoMatriz[i, coluna];
                }
                return SomaB;
            }

            static int FuncaoC(int[,] CalculoMatriz)
            {
                int SomaC = 0;
                for (int i = 0; i < CalculoMatriz.GetLength(0); i++)
                {
                    SomaC += CalculoMatriz[i, i];
                }
                return SomaC;
            }
            static int FuncaoD(int[,] CalculoMatriz)
            {
                int SomaD = 0;
                int tamanho = CalculoMatriz.GetLength(0);
                for (int i = 0; i < tamanho; i++)
                {
                    SomaD += CalculoMatriz[i, CalculoMatriz.GetLength(0) - 1 - i];
                }
                return SomaD;
            }
            static int FuncaoE(int[,] CalculoMatriz)
            {
                int SomaE = 0;
                for (int i = 0; i < CalculoMatriz.GetLength(0); i++)
                {
                    for (int j = 0; j < CalculoMatriz.GetLength(1); j++)
                    {
                        SomaE += CalculoMatriz[i, j];
                    }
                }
                return SomaE;
            }
        }
    }
}

