using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1013
    {
        int a, b, c, maiorAB, maiorAC, maiorBC;
        String[] vet = Console.ReadLine().Split(' ');

        private void CalculaMaior()
        {
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            maiorAB = (a + b + Math.Abs(a - b)) / 2;

            int resultado;

            if (maiorAB > (maiorAC = (a + c + Math.Abs(a - c)) / 2))
                resultado = maiorAB;
            else if (maiorAC > ((maiorBC = (b + c + Math.Abs(b - c)) / 2)))
                resultado = maiorAC;
            else
                resultado = maiorBC;

            Console.WriteLine($"{resultado} eh o maior");
        }
    }
}
