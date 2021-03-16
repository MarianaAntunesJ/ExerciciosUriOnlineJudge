using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1019
    {
        int n, horas, resto, minutos, segundos;

        private void CalculaHoras()
        {
            n = int.Parse(Console.ReadLine());

            horas = n / 3600;
            resto = n % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}
