using System;
using System.Globalization;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1060
    {
        int soma = 0;
        float[] vet = new float[6];

        private void CalculaSoma()
        {
            for (int i = 0; i < 6; i++)
            {
                vet[i] = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (vet[i] > 0.0)
                    soma += 1;
            }
            Console.WriteLine($"{soma} valores positivos");
        }
    }
}
