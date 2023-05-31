using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasATP
{
    public static class L5Q06
    {
        public static void Executar()
        {
            int[] TempDia = new int[31];
            Random t = new Random();

            int menorTemp = 40;
            int maiorTemp = 0;

            int TempInferior = 0;


            for (int i = 0; i < TempDia.Length; i++)
            {
                TempDia[i] = t.Next(15, 40);

                if (menorTemp > TempDia[i])
                {
                    menorTemp = TempDia[i];
                }
                if (maiorTemp < TempDia[i])
                {
                    maiorTemp = TempDia[i];
                }
            }

            int aux = 0;

            for (int i = 0; i < TempDia.Length; i++)
            {
                aux += TempDia[i];
            }

            int TempMedia = aux / 31;

            for (int i = 0; i < TempDia.Length; i++)
            {
                if (TempDia[i] > TempMedia)
                {
                    TempInferior++;
                }
            }

            Console.WriteLine("\nA menor temperatura registrada foi de {0}, a maior foi de {1}.\nA temperatura média foi de: {2}.\nDias que tiveram a temperatura abaixo da média: {3}.\n"
            , menorTemp, maiorTemp, TempMedia, TempInferior);
        }
    }
}