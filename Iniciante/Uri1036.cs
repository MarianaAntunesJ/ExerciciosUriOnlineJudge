using System;
using System.Globalization;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1036
    {
        double a, b, c, delta, x1, x2;
        String[] vet = Console.ReadLine().Split(' ');

        private void CalculaDelta()
        {
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            if (delta < 0 || a == 0)
                Console.WriteLine("Impossivel calcular");
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("R1 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}
