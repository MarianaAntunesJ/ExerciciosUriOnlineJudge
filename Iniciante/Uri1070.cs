using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1070
    {
        int x = int.Parse(Console.ReadLine());

        private void CalculaResto()
        {
            for (int i = x; i < (x + 12); i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }
        }
    }
}
