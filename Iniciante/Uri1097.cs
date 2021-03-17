using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1097
    {
        private void Calculo()
        {
            for (int i = 1; i <= 9; i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = (i + 6); j > (i + 3); j--)
                        Console.WriteLine($"I={i} J={j}");
                }
            }
        }
    }
}
