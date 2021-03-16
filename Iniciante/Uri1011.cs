using System;
using System.Globalization;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1011
    {
        double raio, volume;
        
        private void CalculaVolume()
        {
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            volume = (4.0 / 3) * 3.14159 * Math.Pow(raio, 3.0);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
