using System;
using System.Globalization;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1037
    {
        double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        private void CalculaIntervalo()
        {
            if (a < 0.0 || a > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (a <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (a <= 50.0)
            {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if (a <= 75.0)
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo [75,100]");
            }
        }
    }
}
