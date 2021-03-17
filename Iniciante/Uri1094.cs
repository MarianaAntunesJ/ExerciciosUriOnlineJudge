using System;
using System.Globalization;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1094
    {
        int n = int.Parse(Console.ReadLine());

        int rato = 0;
        int sapo = 0;
        int coelho = 0;
        int cobaias = 0;

        private void Calcula()
        {
            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                int quantia = int.Parse(vet[0]);
                char tipo = char.Parse(vet[1]);

                if (tipo == 'C')
                    coelho += quantia;
                else if (tipo == 'R')
                    rato += quantia;
                else if (tipo == 'S')
                    sapo += quantia;
                cobaias += quantia;
            }

            Console.WriteLine($"Total: {cobaias} cobaias\n" +
                        $"Total de coelhos: {coelho}\n" +
                        $"Total de ratos: {rato}\n" +
                        $"Total de sapos: {sapo}\n" +
                        $"Percentual de coelhos: {(((double)coelho / cobaias) * 100.0).ToString("F2", CultureInfo.InvariantCulture)} %\n" +
                        $"Percentual de ratos: {(((double)rato / cobaias) * 100.0).ToString("F2", CultureInfo.InvariantCulture)} %\n" +
                        $"Percentual de sapos: {(((double)sapo / cobaias) * 100.0).ToString("F2", CultureInfo.InvariantCulture)} %");
        }
    }
}
