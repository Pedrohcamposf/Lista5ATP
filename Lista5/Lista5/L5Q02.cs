﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasATP
{
    public static class L5Q02
    {
        public static void Executar()
        {
            int[] notasAlunos = new int[10];

            notasAlunos = PreencheVetor(notasAlunos);

            CalculaMedia(notasAlunos);


            static int[] PreencheVetor(int[] notas)
            {

                Random rd = new Random();
                for (int i = 0; i < notas.Length; i++)
                {
                    notas[i] = rd.Next(0, 101);
                }
                return notas;
            }

            static void CalculaMedia(int[] notas)
            {
                double media, somatorio = 0;
                int cont = 0;

                foreach (int item in notas)
                {
                    somatorio += item;
                }
                media = somatorio / notas.Length;

                for (int i = 0; i < notas.Length; i++)
                {
                    if (notas[i] > media)
                        cont++;
                }

                Console.WriteLine($"A média da turma é: {media}");
                Console.WriteLine($"Total de alunos acima da média: {cont}");
            }


        }
    }
}