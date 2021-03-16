using System;
using System.Globalization;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1015
    {
        double x1, y1, x2, y2, distancia;
        String[] vet = Console.ReadLine().Split(' ');

        private void CalculaDistancia()
        {
            x1 = double.Parse(vet[0].Replace('.', ','));
            y1 = double.Parse(vet[1].Replace('.', ','));
            vet = Console.ReadLine().Split(' ');
            x2 = double.Parse(vet[0].Replace('.', ','));
            y2 = double.Parse(vet[1].Replace('.', ','));

            distancia = Math.Sqrt((Math.Pow(x2 - x1, 2.0)) + (Math.Pow(y2 - y1, 2.0)));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
