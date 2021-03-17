using System;
using System.Globalization;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1066
    {
        int somaPar = 0;
        int somaImpar = 0;
        int somaPos = 0;
        int somaNeg = 0;
        float[] vet = new float[5];

        private void CalculaSoma()
        {
            for (int i = 0; i < 5; i++)
            {
                vet[i] = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (vet[i] % 2 == 0)
                    somaPar += 1;
                else
                    somaImpar += 1;
                if (vet[i] > 0)
                    somaPos += 1;
                else if (vet[i] < 0)
                    somaNeg += 1;
            }
            Console.WriteLine($"{somaPar} valor(es) par(es)\n{somaImpar} valor(es) impar(es)\n" +
                        $"{somaPos} valor(es) positivo(s)\n{somaNeg} valor(es) negativo(s)");
        }
    }
}
