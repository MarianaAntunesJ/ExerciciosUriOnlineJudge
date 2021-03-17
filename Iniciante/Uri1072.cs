using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1072
    {
        int dentro = 0;
        int fora = 0;
        int n = int.Parse(Console.ReadLine());

        private void Calcula()
        {
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                    dentro += 1;
                else
                    fora += 1;
            }
            Console.WriteLine($"{dentro} in\n" +
                                      $"{fora} out");
        }
    }
}
