using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1074
    {
        int n = int.Parse(Console.ReadLine());

        private void Calcula()
        {
            for (int i = 0; i < n; i++)
            {
                int valor = int.Parse(Console.ReadLine());
                if (valor == 0)
                    Console.WriteLine("NULL");
                else if (valor % 2 == 0)
                    if (valor > 0)
                        Console.WriteLine("EVEN POSITIVE");
                    else
                        Console.WriteLine("EVEN NEGATIVE");
                else
                     if (valor > 0)
                    Console.WriteLine("ODD POSITIVE");
                else
                    Console.WriteLine("ODD NEGATIVE");
            }
        }
    }
}
