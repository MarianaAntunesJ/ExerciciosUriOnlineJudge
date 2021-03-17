using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1131
    {
        int n = int.Parse(Console.ReadLine());
        int soma = 0;

        private void Calcula()
        {
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                soma += num;
            }

            Console.WriteLine(soma);
        }
    }
}
