using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1115
    {
        int x, y;

        private void Calcula()
        {
            do
            {
                string[] vet = Console.ReadLine().Split(' ');

                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                if (x > 0 && y > 0)
                    Console.WriteLine("primeiro");
                else if (x < 0 && y > 0)
                    Console.WriteLine("segundo");
                else if (x < 0 && y < 0)
                    Console.WriteLine("terceiro");
                else if (x > 0 && y < 0)
                    Console.WriteLine("quarto");
            } while (x != 0 && y != 0);
        }
    }
}
