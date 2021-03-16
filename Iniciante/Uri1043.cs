using System;
using System.Globalization;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1043
    {
        String[] vet = Console.ReadLine().Split(' ');

        private void EntradaDeDados()
        {

            float a = float.Parse(vet[0], CultureInfo.InvariantCulture);
            float b = float.Parse(vet[1], CultureInfo.InvariantCulture);
            float c = float.Parse(vet[2], CultureInfo.InvariantCulture);


            if (CalculoTriangulo(a, b, c) && CalculoTriangulo(b, c, a) && CalculoTriangulo(c, b, a))
                Console.WriteLine($"Perimetro = {(a + b + c).ToString("F1", CultureInfo.InvariantCulture)}");
            else
                Console.WriteLine($"Area = {((a + b) * c / 2).ToString("F1", CultureInfo.InvariantCulture)}");
        }
        private bool CalculoTriangulo(float a, float b, float c)
        {
            if ((a - c) < b && b < (a + c))
                return true;
            return false;
        }
    }
}
