using System;
using System.Globalization;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1002
    {
        double raio, area;
        double n = 3.14159;

        private void CalculaArea()
        {
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = n * (raio * raio);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }        
    }
}
