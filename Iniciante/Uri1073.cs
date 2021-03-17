using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1073
    {
        int n = int.Parse(Console.ReadLine());

        private void CalculaPotencia()
        {
            for (int i = 1; i <= n; i++)
                if (i % 2 == 0)
                    Console.WriteLine($"{i}^2 = {i * i}");
        }
    }
}
