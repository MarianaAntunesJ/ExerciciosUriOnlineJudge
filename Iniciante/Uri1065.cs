using System;
using System.Globalization;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1065
    {
        int soma = 0;
        float[] vet = new float[5];

        private void CalculaPar()
        {
            for (int i = 0; i < 5; i++)
            {
                vet[i] = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (vet[i] % 2 == 0)
                {
                    soma += 1;
                }
            }
            Console.WriteLine($"{soma} valores pares");
        }
    }
}
