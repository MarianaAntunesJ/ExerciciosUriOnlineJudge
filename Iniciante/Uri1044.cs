using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1044
    {
        String[] vet = Console.ReadLine().Split(' ');

        private void CalculaMultiplo()
        {
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);

            if (a % b == 0 || b % a == 0)
                Console.WriteLine("Sao Multiplos");
            else
                Console.WriteLine("Nao sao Multiplos");
        }
    }
}
