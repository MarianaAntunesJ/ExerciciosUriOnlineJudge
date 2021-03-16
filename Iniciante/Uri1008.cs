using System;
using System.Globalization;

namespace ExerciciosUriJudgeOnline.Iniciante
{
    class Uri1008
    {
        int numFuncionario, horasTrabalhadas;
        float valorHora, salario;

        private void CalculaSalario()
        {
            numFuncionario = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            horasTrabalhadas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valorHora = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horasTrabalhadas * valorHora;

            Console.WriteLine("NUMBER = " + numFuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
