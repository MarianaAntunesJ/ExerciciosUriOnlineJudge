using System;
using System.Collections.Generic;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1133
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        List<int> lista = new List<int>();

        private void Calcula()
        {
            if (x < y)
            {
                for (int i = x; i < y; i++)
                    if (i % 5 == 2 || i % 5 == 3)
                    {
                        lista.Add(i);
                    }

            }
            else if (x > y)
            {
                for (int i = y; i < x; i++)
                    if (i % 5 == 2 || i % 5 == 3)
                    {
                        lista.Add(i);
                    }
            }

            foreach (int item in lista)
                Console.WriteLine(item);
        }
    }
}
