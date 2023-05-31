using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasATP
{
    public static class L5Q05
    {
        public static void Executar()
        {
            int[] sorteio = new int[3];
            sorteio = Aleatorio(sorteio);
            for (int i = 0; i < sorteio.Length; i++)
            {
                Console.WriteLine("{0}", sorteio[i]);
            }
            Tentativas(sorteio);
        }
        public static int[] Aleatorio(int[] sort)
        {
            Random r = new Random();
            for (int i = 0; i < sort.Length; i++)
            {
                sort[i] = r.Next(10, 50);
            }
            return sort;
        }
        public static void Tentativas(int[] NumSorteado)
        {
            int indice = 0;
            int TE = 0;
            do
            {
                Console.WriteLine("Adivinhe o número de 10 a 50: ");
                TE = int.Parse(Console.ReadLine());
                indice++;
            } while (TE != NumSorteado[0] && TE != NumSorteado[1] &&  TE != NumSorteado[2]);

            int[] TentativasErradas = new int[indice];

            Console.WriteLine("Você errou {0} vezes, sendo os seguintes números:\n", indice - 1);

        }
    }
}
