using System;
using System.Globalization;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1064
    {
        int soma = 0;
        float media = 0;
        float[] vet = new float[6];

        private void CalculaValor()
        {
            for (int i = 0; i < 6; i++)
            {
                vet[i] = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (vet[i] > 0.0)
                {
                    media += vet[i];
                    soma += 1;
                }
            }
            Console.WriteLine($"{soma} valores positivos\n{(media / soma).ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}
