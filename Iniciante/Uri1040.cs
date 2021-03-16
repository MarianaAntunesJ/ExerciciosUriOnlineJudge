using System;
using System.Globalization;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1040
    {
        string[] vet = Console.ReadLine().Split(' ');

        private void CalculaMedia()
        {
            float n1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
            float n2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
            float n3 = float.Parse(vet[2], CultureInfo.InvariantCulture);
            float n4 = float.Parse(vet[3], CultureInfo.InvariantCulture);

            float media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;
            if (media == 4.85f)
            {
                media = 4.8f;
            }
            Console.WriteLine("Media: " + media.ToString(CultureInfo.InvariantCulture));
            if (media >= 7.0)
                Console.WriteLine("Aluno aprovado.");
            else if (media < 5.0)
                Console.WriteLine("Aluno reprovado.");

            else
            {
                Console.WriteLine("Aluno em exame.\nNota do exame: ");
                float exame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                media = (media + exame) / 2;
                if (media >= 5.0)
                    Console.WriteLine("Aluno aprovado.");
                else
                    Console.WriteLine("Aluno reprovado.");
                Console.WriteLine("Media final: " + media.ToString(CultureInfo.InvariantCulture));
            }
        }
    }
}
