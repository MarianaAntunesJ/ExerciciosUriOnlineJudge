using System;
using System.Globalization;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1014
    {
        int x;
        double y;

        private void CalculaDivisao()
        {
            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine((x / y).ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
