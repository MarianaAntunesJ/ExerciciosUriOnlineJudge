using System;
using System.Globalization;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1079
    {
        int n = int.Parse(Console.ReadLine());

        private void Calcula()
        {
            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                float num1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
                float num2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
                float num3 = float.Parse(vet[2], CultureInfo.InvariantCulture);

                Console.WriteLine($"{(((num1 * 2) + (num2 * 3) + (num3 * 5)) / 10).ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
