using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1132
    {
        int soma = 0;
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        private void Calcula()
        {
            if (x < y)
            {
                for (int i = x; i <= y; i++)
                    if (i % 13 != 0)
                        soma += i;
            }
            else if (x > y)
            {
                for (int i = y; i <= x; i++)
                    if (i % 13 != 0)
                        soma += i;
            }
            Console.WriteLine(soma);
        }
    }
}
