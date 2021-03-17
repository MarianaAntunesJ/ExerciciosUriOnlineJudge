using System;
using System.Globalization;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1154
    {
        private void Calcula()
        {
            Console.WriteLine(CalculoIdadesEntrada().ToString("F2", CultureInfo.InvariantCulture));
        }

    static float CalculoIdadesEntrada()
    {
        int idade, quantidade = 0;
        float soma = 0;
        bool idadeValida;
        do
        {
            idade = int.Parse(Console.ReadLine());
            idadeValida = idade > 0;
            if (idadeValida)
            {
                soma += idade;
                quantidade += 1;
            }
        } while (idadeValida);
        return soma /= quantidade;
    }
}
}
