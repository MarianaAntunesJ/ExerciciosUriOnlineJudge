using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1003
    {
        int A, B, SOMA;

        private void CalculaSoma()
        {
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            SOMA = A + B;

            Console.WriteLine("SOMA = " + SOMA);
        }
    }
}
