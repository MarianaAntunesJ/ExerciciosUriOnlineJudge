using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1080
    {
        int n, valor;
        int posicao = 0;
        int maior = 0;

        private void CalculaMaior()
        {
            for (int i = 1; i <= 100; i++)
            {
                n = int.Parse(Console.ReadLine());
                valor = n;
                if (valor > maior)
                {
                    maior = valor;
                    posicao = i;
                }
            }
            Console.WriteLine($"{maior}\n{posicao}");
        }
    }
}
