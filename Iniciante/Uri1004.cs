using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1004
    {
        int a, b, prod;

        private void CalculaProduto()
        {
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            prod = a * b;
            Console.WriteLine("PROD = " + prod);
        }
    }
}
