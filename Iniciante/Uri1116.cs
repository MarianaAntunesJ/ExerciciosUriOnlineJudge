using System;
using System.Globalization;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1116
    {
        int n = int.Parse(Console.ReadLine());

        private void CalculaDivisao()
        {
            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                int x = int.Parse(vet[0]);
                int y = int.Parse(vet[1]);

                if (y != 0)
                    Console.WriteLine($"{((double)x / y).ToString("F1", CultureInfo.InvariantCulture)}");
                else
                    Console.WriteLine("divisao impossivel");
            }
        }
    }
}
