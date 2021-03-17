using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1075
    {
        int n = int.Parse(Console.ReadLine());

        private void Calculo()
        {
            for (int i = 1; i <= 10000; i++)
                if (i % n == 2)
                    Console.WriteLine(i);
        }
    }
}
