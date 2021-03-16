using System;
using System.Globalization;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1041
    {
        string[] vet = Console.ReadLine().Split(' ');

        private void CalculaPonto()
        {
            float x = float.Parse(vet[0], CultureInfo.InvariantCulture);
            float y = float.Parse(vet[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0)
                Console.WriteLine("Origem");
            else if (x >= 0.1 && y >= 0.1)
                Console.WriteLine("Q1");
            else if (x < 0.0 && y >= 0.1)
                Console.WriteLine("Q2");
            else if (x < 0.0 && y < 0.0)
                Console.WriteLine("Q3");
            else if (x >= 0.1 && y < 0.0)
                Console.WriteLine("Q4");
        }
    }
}
