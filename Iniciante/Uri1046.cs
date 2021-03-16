using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1046
    {
        string[] vet = Console.ReadLine().Split(' ');

        private void CalculaDuracao()
        {
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);

            int total;
            if (a >= b)
            {
                total = 24 - a;
                total += b;
            }
            else
                total = b - a;
            Console.WriteLine("O JOGO DUROU " + total + " HORA(S)");
        }
    }
}
