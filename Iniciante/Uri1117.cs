using System;
using System.Globalization;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1117
    {
        private void Calcula()
        {
            float nota1 = ValidacaoNotas();
            float nota2 = ValidacaoNotas();
            Console.WriteLine($"media = {((nota1 + nota2) / 2).ToString("F2", CultureInfo.InvariantCulture)}");
        }

        private float ValidacaoNotas()
        {
            float nota;
            do
            {
                nota = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            } while (VerificacaoNotaInvalida(nota));
            return nota;
        }

        private bool VerificacaoNotaInvalida(float nota)
        {
            if (nota >= 0 && nota <= 10)
                return false;

            Console.WriteLine("nota invalida");
            return true;
        }
    }
}
