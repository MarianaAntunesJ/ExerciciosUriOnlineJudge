using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1067
    {
        int x = int.Parse(Console.ReadLine());

        private void CalculaResto()
        {
            for (int i = 1; i <= x; i++)
                if (i % 2 != 0)
                    Console.WriteLine(i);
        }
    }
}
