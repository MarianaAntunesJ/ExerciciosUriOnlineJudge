using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1078
    {
        int n = int.Parse(Console.ReadLine());

        private void Calcula()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {n} = {i * n}");
            }
        }
    }
}
