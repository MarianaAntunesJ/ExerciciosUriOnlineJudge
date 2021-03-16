using System;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1042
    {
        String[] vet = Console.ReadLine().Split(' ');

        private void Calcula()
        {
            int numUm = int.Parse(vet[0]);
            int numDois = int.Parse(vet[1]);
            int numTres = int.Parse(vet[2]);

            int num1 = numUm;
            int num2 = numDois;
            int num3 = numTres;

            if (num1 > num2)
            {
                int aux = num1;
                num1 = num2;
                num2 = aux;
            }

            if (num1 > num3)
            {
                int aux = num1;
                num1 = num3;
                num3 = aux;
            }

            if (num2 > num3)
            {
                int aux = num2;
                num2 = num3;
                num3 = aux;
            }

            Console.WriteLine(num1 + "\n" + num2 + "\n" + num3 + "\n");
            Console.WriteLine(numUm + "\n" + numDois + "\n" + numTres);
        }
    }
}
