using System;
using System.Globalization;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1007
    {
        int a, b, c, d, diferenca;

        private void CalculaDiferenca()
        {
            a = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            d = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            diferenca = (a * b) - (c * d);

            Console.WriteLine("DIFERENCA = " + diferenca);
        }
    }
}
