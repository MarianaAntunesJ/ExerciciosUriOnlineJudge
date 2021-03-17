using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1071
    {
        int soma = 0;
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        private void CalculaSoma()
        {
            if (x > y)
            {
                for (int i = (y + 1); i < x; i++)
                    if (i % 2 != 0)
                        soma += i;
            }
            else
            {
                for (int i = (x + 1); i < y; i++)
                    if (i % 2 != 0)
                        soma += i;
            }
            Console.WriteLine(soma);
        }
    }
}
