using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1096
    {
        private void Calcula()
        {
            for (int i = 1; i <= 9; i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = 7; j > 4; j--)
                        Console.WriteLine($"I={i} J={j}");
                }
            }
        }
    }
}
