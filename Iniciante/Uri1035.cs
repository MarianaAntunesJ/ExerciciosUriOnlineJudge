using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1035
    {
        int a, b, c, d;
        string[] vet = Console.ReadLine().Split(' ');

        private void CalculaValores()
        {
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);
            d = int.Parse(vet[3]);

            if (b > c && d > a && c + d > a + b && c > 0 && d > 0 && a % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
                Console.WriteLine("Valores nao aceitos");
        }
    }
}
